namespace GraphQlDemo.Models;

public class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }

    public Person(int id, string firstName, string lastName, string address)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Address = address;
    }
}
