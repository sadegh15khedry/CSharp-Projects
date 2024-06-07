using GraphQlDemo.Models;

namespace GraphQlDemo.Services
{
    public interface IPersonService
    {
        Task<IEnumerable<Person>> GetPeople();
    }
}