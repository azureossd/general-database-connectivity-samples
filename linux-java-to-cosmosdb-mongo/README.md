# Test Java connecting to CosmosDB with Mongo

## 1. Download latest version of Maven
> wget https://mirrors.ucr.ac.cr/apache/maven/maven-3/3.6.3/binaries/apache-maven-3.6.3-bin.tar.gz

## 2. Decompress the file
> tar xzvf apache-maven-3.6.3-bin.tar.gz

## 3. Add Maven to the PATH
> export PATH=/home/site/wwwroot/apache-maven-3.6.3/bin:$PATH

## 4. Check Maven version
> mvn -version
> ![image](https://user-images.githubusercontent.com/36493244/136632034-257fe667-2e8c-4534-ad90-c45c8e3414f0.png)

## 5. Create Maven project
> 	mvn archetype:generate -DgroupId=com.mycompany.app -DartifactId=my-app -DarchetypeArtifactId=maven-archetype-quickstart -DarchetypeVersion=1.4 -DinteractiveMode=false

## 6. Get into my-app
> cd my-app

## 7. Edit pom.xml file and use the content of pom.xml in this repository

## 8. Get into the java files folder and use the content of App.java in this repository
> cd src/main/java/com/mycompany/app

## 9. Edit App.java file and use the content of App.java in this repository

## 10. Now you need a model to hold the data you are pulling, In this case I am creating Employee.java, you can use the content of Employee.java in this repository as an example

## 11. Go back to the folder path /home/site/wwwroot/my-app
> cd /home/site/wwwroot/my-app 

## 12. Compile the project
> mvn compile

## 13. Run the project
> mvn exec:java -Dexec.mainClass=com.mycompany.app.App

## 14. Result:
![image](https://user-images.githubusercontent.com/36493244/136632731-43bc1bb6-0eaf-4367-82ef-03acd76af57d.png)







