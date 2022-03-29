using System.Runtime.Serialization;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace app
	{	
		[DataContract]
	    public class Employee
	    {
			[BsonId]
			 public ObjectId _id { get; set; }

			[DataMember]
	        public int id { get; set; }

			[DataMember]
	        public string name { get; set; }

			[DataMember]
	        public string age { get; set; }

			[DataMember]
	        public string gender { get; set; }
	    }
}