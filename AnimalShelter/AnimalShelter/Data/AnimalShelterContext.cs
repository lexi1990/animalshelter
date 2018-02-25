using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
    public class AnimalShelterContext : DbContext
    {
        public AnimalShelterContext (DbContextOptions<AnimalShelterContext> options)
            : base(options)
        {
        }

        public DbSet<AnimalShelter.Models.Animals> Animals { get; set; }
    }
}
