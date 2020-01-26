set base_path=c:\influx\
set image=influxdb

set wal_drive=-v %base_path%wal:/var/lib/influxdb/wal
set data_drive=-v %base_path%data:/var/lib/influxdb/data
set ports=-p 8086:8086 -p 8088:8088 

set run_cmd=run -it --rm --cpus 16  --name influxdb %ports% %data_drive% %wal_drive%

@CALL docker %run_cmd% %image%