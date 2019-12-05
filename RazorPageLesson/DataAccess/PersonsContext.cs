using Microsoft.EntityFrameworkCore;
using RazorPageLesson.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPageLesson.DataAccess
{
    public class PersonsContext : DbContext
    {
        public PersonsContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData(
                new Person
                {
                    FullName = "Петр Петрович",
                    Age = 56
                }
            );
            modelBuilder.Entity<Person>().HasData(
                new Person
                {
                    FullName = "Вася Тулегенов",
                    Age = 18
                }
            );
        }
        public DbSet<Person> People { get; set; }
    }
}
