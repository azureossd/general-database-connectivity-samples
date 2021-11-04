	const CosmosClient = require('@azure/cosmos').CosmosClient
	const endpoint = 'https://<CosmosServerName>.documents.azure.com:443/'
	const key = '<PrimaryKey>'
	const databaseId = '<DatabaseName>'
	const containerId = '<ContainerName>'
	const client = new CosmosClient({ endpoint, key })
	
	async function queryItems() {
	  const querySpec = {
	    query: 'SELECT r.name, r.age, r.gender FROM root r'
	  }
	  
	  const { resources: results } = await client
	    .database(databaseId)
	    .container(containerId)
	    .items.query(querySpec)
	    .fetchAll()
	  for (var queryResult of results) {
	    let resultString = JSON.stringify(queryResult)
	    console.log(`${resultString}`)
	  }
	}
	
queryItems()
