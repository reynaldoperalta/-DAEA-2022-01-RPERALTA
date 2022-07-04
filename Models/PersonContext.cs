using Microsoft.EntityFrameworkCore;
using System;
using persons.Models;

namespace persons.Models
{
    public class PersonContext: DbContext
    {
        public PersonContext(DbContextOptions<PersonContext> options)
            : base(options)
            {
            
             }
            public DbSet<person> Person {get; set;}
            
    }
}