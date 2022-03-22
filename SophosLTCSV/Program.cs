using System;
using System.Diagnostics.Metrics;
using System.IO;
using System.Text;

namespace LTCSV
{
    public static class Program
    {

        public static void Main(string[] args)
        {
            if (args.Length < 2 )
            {
                Console.WriteLine("Error: please provide an input AND output file");
                Environment.Exit(0);
            }
            if (!File.Exists(args[0]))
            {
                Console.WriteLine(String.Format("Error, file {0} not found"), args[0]);
                Environment.Exit(0);
            }

            if (!File.Exists(args[1]))
            {
                try
                {
                    File.Create(args[1]);
                }
                catch (Exception e)
                {
                    Console.WriteLine(String.Format("Error while trying to write to {0}. \nError: {1}"), args[1], e.ToString());
                    Environment.Exit(0);
                }
            }

            using (FileStream fs = File.Open(args[1], FileMode.Open, FileAccess.Write, FileShare.None))
            {
                Byte[] info = new UTF8Encoding(true).GetBytes("This is some text in the file.");
                List<char> outTXT = new List<char>();
                bool inside = false;

                using (StreamReader reader = new StreamReader(args[0]))
                {
                    string line = "";
                    while ((line = reader.ReadLine()) != null)
                    {
                        outTXT.Clear();
                        for (int i = 0; i < line.Length; i++)
                        {
                            if (inside)
                            {
                                if (line[i] == '"')
                                {
                                    inside = false;
                                    outTXT.Add(line[i]);
                                }
                                else
                                {
                                    outTXT.Add(line[i]);
                                }
                            }
                            else
                            {
                                if (line[i] == '"')
                                {
                                    inside = true;
                                    outTXT.Add(line[i]);
                                }
                                else if (line[i] == ' ')
                                {
                                    outTXT.Add(';');
                                }
                                else
                                {
                                    outTXT.Add(line[i]);
                                }
                            }
                        }
                        outTXT.Add(('\n'));
                        byte[] outBytes = new UTF8Encoding(true).GetBytes(outTXT.ToArray());
                        fs.Write(outBytes, 0, outBytes.Length);
                    }
                }
            }
        }
    }
}