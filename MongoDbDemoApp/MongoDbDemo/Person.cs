using MongoDB.Bson.Serialization.Attributes;

namespace MongoDbDemo;

public class Person
{
    [BsonId]
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string SSN { get; set; }
}
