	package com.mycompany.app;
	
	import com.azure.cosmos.ConsistencyLevel;
	import com.azure.cosmos.CosmosClient;
	import com.azure.cosmos.CosmosClientBuilder;
	import com.azure.cosmos.CosmosContainer;
	import com.azure.cosmos.CosmosDatabase;
	import com.azure.cosmos.models.CosmosQueryRequestOptions;
	import com.azure.cosmos.util.CosmosPagedIterable;
	
	import java.util.Collections;
	
	public class App {
	
	    private CosmosClient client;
	
	    public void close() {
	        client.close();
	    }
	
	    public static void main(String[] args) {
	        App p = new App();
			
	        try {
	            p.queryItems();
	        } catch (Exception e) {
	            System.out.println("Error: " + e.getMessage());
	        } finally {
	            p.close();
	        }
	        System.exit(0);
	    }
	
	    private void queryItems() throws Exception {
	        client = new CosmosClientBuilder()
	                .endpoint("https://<CosmosServerName>.documents.azure.com:443/")
	                .key("<PrimaryKey>")
	                .preferredRegions(Collections.singletonList("East US"))
	                .consistencyLevel(ConsistencyLevel.EVENTUAL)
	                .buildClient();
	
	        CosmosDatabase database = client.getDatabase("<DatabaseName>");
	        CosmosContainer container = database.getContainer("<ContainerName>");
	        CosmosPagedIterable<Employee> employees  = container.queryItems("SELECT r.id, r.name, r.age, r.gender FROM root r", new CosmosQueryRequestOptions(), Employee.class);
	
	        employees.iterator().forEachRemaining(item -> {
	            System.out.println("==============================");  
	            System.out.println("ID: " + item.getId());
	            System.out.println("NAME: " + item.getName());
	            System.out.println("AGE: " + item.getAge());
	            System.out.println("GENDER: " + item.getGender()); 
	        });
	        System.out.println("==============================");  
	    }
	}
