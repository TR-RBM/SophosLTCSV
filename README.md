# SophosLTCSV
C# .NET Sophos Firewall Log to CSV Converter

# usage example
- Windows: 
  - SophosLTCSV.exe C:\Users\admin\Desktop\firewall.log C:\Users\admin\Desktop\firewall.csv
- Linux:
  - dotnet SophosLTCSV.dll /root/firewall.log /root/firewall.csv

# example data
- example input:
  - Mar 21 03:38:35 10.0.0.1 device="SFW" date=2022-03-21 time=03:38:36 timezone="CET" device_name="XG***" device_id=************* log_id=*********** log_type="Firewall" log_component="Firewall Rule" log_subtype="Denied" status="Deny" priority=Information duration=0 fw_rule_id=69 nat_rule_id=0 policy_type=1 user_name="" user_gp="" iap=2 ips_policy_id=0 appfilter_policy_id=0 application="" application_risk=0 application_technology="" application_category="" vlan_id="" ether_type=IPv4 (0x0800) bridge_name="" bridge_display_name="" in_interface="lag0.1" in_display_interface="vlan100_DMZ1" out_interface="Port2" out_display_interface="Internet" src_mac=AA:BB:CC:DD:EE:FF dst_mac= src_ip=192.168.101.100 src_country_code=R1 dst_ip=1.1.1.1 dst_country_code=USA protocol="TCP" src_port=20000 dst_port=443 sent_pkts=0  recv_pkts=0 sent_bytes=0 recv_bytes=0 tran_src_ip= tran_src_port=0 tran_dst_ip= tran_dst_port=0 srczonetype="" srczone="" dstzonetype="" dstzone="" dir_disp="" connid="" vconnid="" hb_health="No Heartbeat" message="" appresolvedby="Signature" app_is_cloud=0
- example output:
  - Mar;21;03:38:35;10.0.0.1;device="SFW";date=2022-03-21;time=03:38:36;timezone="CET";device_name="XG***";device_id=*************;log_id=***********;log_type="Firewall";log_component="Firewall Rule";log_subtype="Denied";status="Deny";priority=Information;duration=0;fw_rule_id=69;nat_rule_id=0;policy_type=1;user_name="";user_gp="";iap=2;ips_policy_id=0;appfilter_policy_id=0;application="";application_risk=0;application_technology="";application_category="";vlan_id="";ether_type=IPv4;(0x0800);bridge_name="";bridge_display_name="";in_interface="lag0.1";in_display_interface="vlan100_DMZ1";out_interface="Port2";out_display_interface="Internet";src_mac=AA:BB:CC:DD:EE:FF;dst_mac=;src_ip=192.168.101.100;src_country_code=R1;dst_ip=1.1.1.1;dst_country_code=USA;protocol="TCP";src_port=20000;dst_port=443;sent_pkts=0;;recv_pkts=0;sent_bytes=0;recv_bytes=0;tran_src_ip=;tran_src_port=0;tran_dst_ip=;tran_dst_port=0;srczonetype="";srczone="";dstzonetype="";dstzone="";dir_disp="";connid="";vconnid="";hb_health="No Heartbeat";message="";appresolvedby="Signature";app_is_cloud=0 

# system requirements
- dotNET 6.0

# input file size limit
- there is (should be) no limit, this tool will read and process the input line by line
