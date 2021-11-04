# Test Debian connecting to MySQL/MariaDB 

## 1. Install dependencies 
> apt-get update 
> 
> apt-get install mysql-client / apt-get install mariadb-client

## 2. Create the connection
> mysql -u user@MySQLServerName -p  -h MySQLServerName.mysql.database.azure.com -P 3306 -D database

## 3. Query your table
> select * from TableName;

## 4. Result: 
![image](https://user-images.githubusercontent.com/36493244/136247408-f4ec7421-05c5-4977-a036-aacc1a3ba11a.png)


