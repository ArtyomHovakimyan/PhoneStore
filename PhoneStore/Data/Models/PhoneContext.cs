using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneStore.Data.Models
{
    public class PhoneContext:DbContext
    {
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Company> Companies { get; set; }

        public PhoneContext(DbContextOptions<PhoneContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
