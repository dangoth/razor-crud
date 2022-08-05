using Microsoft.EntityFrameworkCore;
using PersonDB.Shared;

namespace PersonDB.Server.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>().HasData(
            new Person { Id = 1, FirstName = "Peter", LastName = "Johns", Gender = GenderEnum.Male, Email = "peter.johns@gmail.com", PhoneNumber = "00312642236", Age = 32 },
            new Person { Id = 2, FirstName = "Joe", LastName = "Walsh", Gender = GenderEnum.Male, Email = "joe23@gmail.com", PhoneNumber = "0048125629349", Age = 28 },
            new Person { Id = 3, FirstName = "Volodymyr", LastName = "Zelensky", Gender = GenderEnum.Male, Email = "Presidentpressoffice@apu.gov.ua", PhoneNumber = "00380442841915", Age = 44 }
            );
    }
    public DbSet<Person> Persons { get; set; }
}
