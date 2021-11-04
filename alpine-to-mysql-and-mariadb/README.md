# Test Alpine connecting to MySQL/MariaDB 

## 1. Install dependencies 
> apk update
>  
> apk add mysql-client / apk add mariadb-client

## 2. Create the connection
> mysql -u user@MySQLServerName -p'password' -h MySQLServerName.mysql.database.azure.com -P 3306 -D database

## 3. Query your table
> select * from TableName;

## 4. Result: 
![image](https://user-images.githubusercontent.com/36493244/136251240-14b06640-d4ca-4b5d-b683-40772d38f7b6.png)
  
NOTE: If you do get an error saying: "SSL connection is requeried. Please specify SSL options and retry" just simply disable "Enforce SSL connection" from the database configuration by going Portal > MySQL Database > Connection security > Enforce SSL connection 



