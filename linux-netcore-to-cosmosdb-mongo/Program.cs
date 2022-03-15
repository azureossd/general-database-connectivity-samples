	using System;
	using System.Threading.Tasks;
	using System.Collections.Generic;
    using System.Security.Authentication;
	using Microsoft.Azure.Cosmos;
    using MongoDB.Driver;
	
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
                
				// Get the connection string from Azure Cosmos DB API for MongoDB account > Connection String > PRIMARY CONNECTION STRING
                string connectionString = @"mongodb://<PRIMARY_CONNECTION_STRING>";

				// Pull up Azure Cosmos DB API for MongoDB account settings 
                MongoClientSettings settings = MongoClientSettings.FromUrl(
                                                    new MongoUrl(connectionString)
                                                );
				
				// Set new SSL protocol settings using TLS 1.2
                settings.SslSettings = new SslSettings() { EnabledSslProtocols = SslProtocols.Tls12 };

				// Connect to Azure Cosmos DB API for MongoDB account
                var mongoClient = new MongoClient(settings);

				// Get the Mongo Database
                var  database = mongoClient.GetDatabase("Employee");

				// Get the Database book collection and map it into a model
                var collection = database.GetCollection<Employee>("Employee");

				// Find all books/documents and put them in a list
				var books = await collection.Find(_ => true).ToListAsync();

				// For each book prints its properties (i.e. id and name)
				books.ForEach(employee => Console.WriteLine(employee.id + " " + employee.name));

	        }
	    }
	}