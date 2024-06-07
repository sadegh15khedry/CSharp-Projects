using GraphQlDemo.Models;
namespace GraphQlDemo.Data;
using System.Linq;
public class Query
{
    public IQueryable<Person> GetPersons;


    public Query()
    {
        IList<Person> _people = new List<Person>();
        _people.Add(new Person(1, "akvar", "akvari", "akvarAbad"));
        _people.Add(new Person(2, "Eli", "eli", "AkvarAbad"));

        GetPersons = _people.AsQueryable();

    }

}
