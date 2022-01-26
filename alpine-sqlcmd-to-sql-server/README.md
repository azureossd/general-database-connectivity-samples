# How to test connection to SQL Server with SQLCMD in Alpine (Java)

## 1. Install dependencies 

```bash
apk add gnupg curl
```	

## 2. Download ODBC driver and SQLCMD packages

```bash
curl -O https://download.microsoft.com/download/e/4/e/e4e67866-dffd-428c-aac7-8d28ddafb39b/msodbcsql17_17.8.1.1-1_amd64.apk
curl -O https://download.microsoft.com/download/e/4/e/e4e67866-dffd-428c-aac7-8d28ddafb39b/mssql-tools_17.8.1.1-1_amd64.apk
```

## 3. (Optional) Verify signature

```bash
curl -O https://download.microsoft.com/download/e/4/e/e4e67866-dffd-428c-aac7-8d28ddafb39b/msodbcsql17_17.8.1.1-1_amd64.sig
curl -O https://download.microsoft.com/download/e/4/e/e4e67866-dffd-428c-aac7-8d28ddafb39b/mssql-tools_17.8.1.1-1_amd64.sig
curl https://packages.microsoft.com/keys/microsoft.asc  | gpg --import -
gpg --verify msodbcsql17_17.8.1.1-1_amd64.sig msodbcsql17_17.8.1.1-1_amd64.apk
gpg --verify mssql-tools_17.8.1.1-1_amd64.sig mssql-tools_17.8.1.1-1_amd64.apk
```	

## 4. Install ODBC and SQLCMD packages

```bash
apk add --allow-untrusted msodbcsql17_17.8.1.1-1_amd64.apk
apk add --allow-untrusted mssql-tools_17.8.1.1-1_amd64.apk
```	

## 5. Add SQLCMD tools to $PATH

```bash
export PATH=$PATH:/opt/mssql-tools/bin
```

## Try out:

```bash    
sqlcmd -S [tcp:<SQL_Server_Name>.database.windows.net | <Hostname>] -d <Database_Name> -U <User_Name> -P <Password> -Q "<Query_Here>"
```
	
Replace the following placeholders with the corresponding values:
- `<SQL_Server_Name>` Azure SQL Server Name if using Azure SQL instance.
- `<Hostname>` Hostname of SQL Server if using on-prem SQL Server instance.
- `<Database_Name>` name of the database you want to connect to.
- `<User_Name>` user name used to log in to the database, for instance: admin.
- `<Password>` user name password.
- `<Query_Here>` query to any table, for instance: "SELECT * FROM dbo.Person"

## Result:
![image](https://user-images.githubusercontent.com/7483684/151251442-e6804c3b-8995-4271-944a-dd63d2452142.png)