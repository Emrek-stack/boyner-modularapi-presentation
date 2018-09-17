using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Pantokrator.Data
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }

    public class SampleDbContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
        public SampleDbContext(DbContextOptions<SampleDbContext> options) : base(options)
        {
        }

        public void GenerateSampleData()
        {
            Contacts.Add(new Contact { Id = 1, FirstName = "John", LastName = "Doe", Email = "john@example.com" });
            Contacts.Add(new Contact { Id = 2, FirstName = "Peter", LastName = "Jones", Email = "peter@example.com" });
            Contacts.Add(new Contact { Id = 3, FirstName = "Mary", LastName = "Smith", Email = "mary@example.com" });
            Contacts.Add(new Contact { Id = 4, FirstName = "Ian", LastName = "Green", Email = "ian@example.com" });
            Contacts.Add(new Contact { Id = 5, FirstName = "Nancy", LastName = "Brownwood", Email = "nancy@example.com" });
            Contacts.Add(new Contact { Id = 6, FirstName = "Tommy", LastName = "High", Email = "tommy@example.com" });
            Contacts.Add(new Contact { Id = 7, FirstName = "Gabriel", LastName = "Santos", Email = "gabriel@example.com" });
            Contacts.Add(new Contact { Id = 8, FirstName = "Ryan", LastName = "James", Email = "ryan@example.com" });
            Contacts.Add(new Contact { Id = 9, FirstName = "Marc", LastName = "James", Email = "marc@example.com" });
            Contacts.Add(new Contact { Id = 10, FirstName = "James", LastName = "Dallas", Email = "james@example.com" });
            Contacts.Add(new Contact { Id = 11, FirstName = "Ron", LastName = "Steer", Email = "ron@example.com" });
            Contacts.Add(new Contact { Id = 12, FirstName = "Liam", LastName = "Schwarz", Email = "liam@example.com" });

            SaveChanges();
        }
    }
}