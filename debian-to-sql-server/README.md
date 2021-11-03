# Test Debian connecting to SQL Server

## 1. Install dependencies 

> curl https://packages.microsoft.com/keys/microsoft.asc | apt-key add - 
> 
>> NOTE: If you get the following error when running the previous command:
>> ![image](https://user-images.githubusercontent.com/36493244/136244625-5a3cc15e-febf-4087-b121-a265f144fb15.png)
>> Go ahead and install gnupg2 with the following command:
>> apt-get update && apt-get install -y gnupg2
>> Then retry running the previous curl:
>> 
>> curl https://packages.microsoft.com/keys/microsoft.asc | apt-key add - 
>
> curl https://packages.microsoft.com/config/ubuntu/16.04/prod.list | tee /etc/apt/sources.list.d/msprod.list
> 
> apt-get update 
> 
> apt-get install mssql-tools unixodbc-dev
> 
> echo 'export PATH="$PATH:/opt/mssql-tools/bin"' >> ~/.bash_profile
> 
> echo 'export PATH="$PATH:/opt/mssql-tools/bin"' >> ~/.bashrc
> 
> source ~/.bashrc

## 2. Query your table

> sqlcmd -S tcp:<SQLServerName>.database.windows.net,1433 -d database -U user -P password -Q "select * from TableName"

## Result:
![image](https://user-images.githubusercontent.com/36493244/136245359-31d28add-bace-4294-badf-b35d4874c2b4.png)


  
  
