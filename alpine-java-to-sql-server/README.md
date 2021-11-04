# Test Linux Java app connecting to SQL Server

## 1. Install dependencies 

> apk update	
>
> apk add nano	
> 
> apk add nano	
> 
>	apk fetch openjdk8	
>	
> apk add openjdk8	
> 
> JAVA_HOME=/usr/lib/jvm/java-1.8-openjdk 	
> 
> PATH="$JAVA_HOME/bin:${PATH}"	 	

## 2. Download jdbc driver for sqlserver 
> wget https://go.microsoft.com/fwlink/?linkid=2153521

## 3. Decompress the file:
> tar -zxvf index.html?linkid\=2153521

## 4. Create sqlserver-connection.java file inside /home/site/wwwroot/ and put the content you have inside this repository
> nano sqlserver-connection.java

## 5. Compile sqlserver-connection.java:
javac -cp ".:sqljdbc_9.2/enu/mssql-jdbc-9.2.0.jre8.jar" sqlserver-connection.java

## 6. Run generated java class:
java -cp ".:sqljdbc_9.2/enu/mssql-jdbc-9.2.0.jre8.jar" SQLDatabaseConnection

## Result:
![image](https://user-images.githubusercontent.com/36493244/136129149-22d7e199-eecf-4275-bbb2-7749d801aec2.png)









