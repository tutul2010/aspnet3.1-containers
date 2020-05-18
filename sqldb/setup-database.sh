



echo 'PLease wait while sql server 2017 is running'

sleep 10s

echo 'Initializing db after 90 second'

/opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P Marine7815@@ -d master -i sql.sh
