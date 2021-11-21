using Microsoft.EntityFrameworkCore;
using net_web_tuto.Models;

namespace net_web_tuto.Database {

    public class ApplicationDbContext : DbContext {

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Person> Persons {get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasKey(person => person.Id);
            modelBuilder.Entity<Person>().Property(person => person.FirstName);
            modelBuilder.Entity<Person>().Property(person => person.LastName);
        }
    }

}