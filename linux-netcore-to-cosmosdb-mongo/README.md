# Test .NET Core connecting to CosmosDB with Mongo

## 1. Download and install .NET Core SDK running the following commands one by one
> wget https://packages.microsoft.com/config/ubuntu/20.10/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
	dpkg -i packages-microsoft-prod.deb
	
## 2. Install SDK
> apt-get update; \
	apt-get install -y apt-transport-https && \
	apt-get update && \
  apt-get install -y dotnet-sdk-3.1
  
## 3. Check SDK was successfully installed
> dotnet --list-sdks
> 
> ![image](https://user-images.githubusercontent.com/36493244/136876835-2be408b9-c97e-44f4-baf2-abdda317e4c2.png)

## 4. Create a folder project and get into it
> mkdir app

## 5. Get into my-app
> cd app

## 6. Create a new console project
> dotnet new console

## 7. Edit Program.cs file and use the content of Program.cs in this repository

## 8. Edit app.csproj file and use the content of app.csproj in this repository

## 9. Now you need a model to hold the data you are pulling, In this case I am creating Employee.cs you can use the content of Employee.cs in this repository as an example

## 10. Run the project

## Result:
![image](https://user-images.githubusercontent.com/36493244/136893250-f833702b-eaf0-426d-b162-97468d3d212c.png)













