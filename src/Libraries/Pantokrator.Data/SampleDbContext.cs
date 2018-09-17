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
            Contacts.Add(new Contact { Id = 1, FirstName = "Emre", LastName = "Karahan", Email = "ekarahan@boynergrup.com" });
            Contacts.Add(new Contact { Id = 2, FirstName = "Turgay", LastName = "Sargın", Email = "tsargin@boynergrup.com" });
            Contacts.Add(new Contact { Id = 3, FirstName = "Selçuk", LastName = "Yıldırım", Email = "syildirim@boynergrup.com" });
            Contacts.Add(new Contact { Id = 4, FirstName = "Rıdvan", LastName = "Eyyüpkoca", Email = "reyyubkoca@boynergrup.com" });
            Contacts.Add(new Contact { Id = 5, FirstName = "Dilara", LastName = "Özırmak", Email = "dozirmak@boynergrup.com" });
            Contacts.Add(new Contact { Id = 6, FirstName = "Ozan Emre", LastName = "Değirmenci", Email = "odegirmenci@boynergrup.com" });
            Contacts.Add(new Contact { Id = 7, FirstName = "Burak", LastName = "Tahtalıoğlu", Email = "btahtalioglu@boynergrup.com" });
            Contacts.Add(new Contact { Id = 8, FirstName = "Filiz", LastName = "Altıntürk", Email = "faltinturk@boynergrup.com" });
            Contacts.Add(new Contact { Id = 9, FirstName = "Ahmet", LastName = "Kurt", Email = "akurt@boynergrup.com" });
            Contacts.Add(new Contact { Id = 10, FirstName = "Berk", LastName = "Yavuz", Email = "byavuz@boynergrup.com" });
            Contacts.Add(new Contact { Id = 11, FirstName = "Muratcan", LastName = "Köker", Email = "mkoker@boynergrup.com" });
            Contacts.Add(new Contact { Id = 12, FirstName = "Barış", LastName = "Gülmez", Email = "bgulmez@boynergrup.com" });

            SaveChanges();
        }
    }
}