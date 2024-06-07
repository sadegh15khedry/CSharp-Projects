using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DataAccess;

public class PeopleContext : DbContext
{
    public PeopleContext(DbContextOptions options) : base(options) { }

    DbSet<Person> Persons { get; set; }
    DbSet<Address> Addresses { get; set; }
}
