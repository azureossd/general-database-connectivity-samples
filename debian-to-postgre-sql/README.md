# Test Debian connecting to PostgreSQL

## 1. Install dependencies 

> apk update	
> 
> apt-get update 
> 
> apt-get install postgresql-client  

## 2. Create the connection

> psql --host=PostgreSQLServerName.postgres.database.azure.com --port=5432 --username=user@PostgreSQLServerName --dbname=database

## 3. Put your database password 

## 4. Query your table
> select * from TableName;

## Result:
![image](https://user-images.githubusercontent.com/36493244/136130699-b7ba3685-c5a1-4f11-80ff-e8ba33142f02.png)


