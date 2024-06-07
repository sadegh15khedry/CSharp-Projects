using CsvHelper.Configuration.Attributes;

namespace OfficeIntegrationDemo.Models;

public class Person
{
    [Name("Id")]
    public int Id { get; set; }
    [Name("FirstName")]
    public string FirstName { get; set; }
    [Name("LastName")]
    public string LastName { get; set; }

}
