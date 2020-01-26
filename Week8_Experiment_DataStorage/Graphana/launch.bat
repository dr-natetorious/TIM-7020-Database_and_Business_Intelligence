set base_path=c:\influx\grafana\
set image=grafana/grafana

mkdir %base_path%var\share\grafana
mkdir %base_path%var\lib\grafana

@REM https://grafana.com/docs/grafana/latest/installation/docker/
set home_drive=-v %base_path%var\share\grafana:/var/share/grafana
set db_drive=-v %base_path%var\lib\grafana:/var/lib/grafana
set ports=-p 3000:3000
set env=-e "GF_SECURITY_ADMIN_USER=grafana" -e "GF_SECURITY_ADMIN_PASSWORD=grafana"

set run_cmd=run -it --rm --cpus 16  --name grafana %env% %ports% %home_drive% %db_drive%

@CALL docker %run_cmd% %image%