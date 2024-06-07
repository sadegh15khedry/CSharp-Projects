using GraphQlDemo.Models;

namespace GraphQlDemo.Services;

public class PersonService : IPersonService
{
    private IList<Person> _people = new List<Person>();


    public PersonService()
    {
        _people.Add(new Person(1, "akvar", "akvari", "akvarAbad"));
        _people.Add(new Person(2, "Eli", "eli", "AkvarAbad"));

    }


    public Task<IEnumerable<Person>> GetPeople()
    {
        return Task.FromResult(_people.AsEnumerable());
    }
}
