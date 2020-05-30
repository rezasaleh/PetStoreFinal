using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetStoreFinalTest.Models;

namespace PetStoreFinalTest.Data
{
    public class PetStoreFinalTestContext : DbContext
    {
        public PetStoreFinalTestContext (DbContextOptions<PetStoreFinalTestContext> options)
            : base(options)
        {
        }

        public DbSet<PetStoreFinalTest.Models.Owner> Owner { get; set; }

        public DbSet<PetStoreFinalTest.Models.Pet> Pet { get; set; }
    }
}
