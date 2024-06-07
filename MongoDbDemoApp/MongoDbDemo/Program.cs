// See https://aka.ms/new-console-template for more information

using MongoDB.Bson;

namespace MongoDbDemo;
public class Program
{
    public static void Main(string[] args)
    {
        BsonDefaults.GuidRepresentation = GuidRepresentation.Standard;
        MongoCRUD db = new MongoCRUD("AddressBook");
        /*        Person person = new Person
                {
                    Id = Guid.NewGuid(),
                    FirstName = "akvar",
                    LastName = "akvar",
                    SSN = "1234567891"
                };*/
        //db.InsertRecord("Users", person);


        var users = db.LoadRecords<Person>("Users");
        Console.WriteLine(users.ToJson());

        Console.WriteLine("----------------------------------------------------------");
        Person person = new Person
        {
            Id = new Guid("26c28830-b4e6-4b7b-a98a-3a1583d5e506"),
            FirstName = "eli",
            LastName = "akvar",
            SSN = "1234567891"
        };

        //db.UpsertRecord<Person>("Users", person.Id, person);

        //var user = db.LoadRecordById<Person>("Users", new Guid("2f07b707-84cd-4454-8cea-a483550ddfb0"));


        //Console.WriteLine(user.ToJson());
    }
}