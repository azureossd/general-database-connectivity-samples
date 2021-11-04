# Test Alpine connecting to PostgreSQL

## 1. Install dependencies 

> apk update 
> 
> apk add postgresql-client 

## 2. Create the connection
> psql --host=PostgreSQLServerName.postgres.database.azure.com --port=5432 --username=user@PostgreSQLServerName --dbname=database

## 3. Put your database password 

## 4. Query your table
> select * from TableName;

## Result:
![image](https://user-images.githubusercontent.com/36493244/136249064-5287e630-0bb9-436a-9332-6fc174a872c1.png)



