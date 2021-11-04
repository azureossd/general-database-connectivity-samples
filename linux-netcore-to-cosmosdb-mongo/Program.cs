	using System;
	using System.Threading.Tasks;
	using System.Collections.Generic;
	using Microsoft.Azure.Cosmos;
	
	namespace app
	{
	    class Program
	    {
	        public static async Task Main(string[] args)
	        {
	            try
	            {
	                Program p = new Program();
	                await p.QueryItemsAsync();
	
	            }
	            catch (CosmosException de)
	            {
	                Exception baseException = de.GetBaseException();
	                Console.WriteLine("{0} error occurred: {1}", de.StatusCode, de);
	            }
	            catch (Exception e)
	            {
	                Console.WriteLine("Error: {0}", e);
	            }            
	        }
	
	        private async Task QueryItemsAsync()
	        {
	            CosmosClient cosmosClient = new CosmosClient("https://<CosmosServerName>.documents.azure.com:443/", "<PrimaryKey>", new CosmosClientOptions() { ApplicationName = "CosmosDBDotnetQuickstart" });
	            Database database = cosmosClient.GetDatabase("<DatabaseName>");
	            Container container = database.GetContainer("<ContainerName>");
	
	            QueryDefinition queryDefinition = new QueryDefinition("SELECT r.id, r.name, r.age, r.gender FROM root r");
	            FeedIterator<Employee> queryResultSetIterator = container.GetItemQueryIterator<Employee>(queryDefinition);
	            List<Employee> families = new List<Employee>();
	
	            while (queryResultSetIterator.HasMoreResults)
	            {
	                FeedResponse<Employee> currentResultSet = await queryResultSetIterator.ReadNextAsync();
	                foreach (Employee employee in currentResultSet)
	                {
	                    Console.WriteLine("=============================================");
	                    Console.WriteLine("ID: " + employee.id);
	                    Console.WriteLine("Name: " + employee.name);
	                    Console.WriteLine("Age: " + employee.age);
	                    Console.WriteLine("Gender: " + employee.gender);
	                }
	                Console.WriteLine("=============================================");
	
	            }
	        }
	    }
	}
