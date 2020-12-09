using Microsoft.EntityFrameworkCore;
using Modal;
using System;
using System.Collections.Generic;
using System.Text;

namespace AttorneyService.DataAccessLayer
{
    public class AtorneyDbContext:DbContext
    {
        public AtorneyDbContext(DbContextOptions<AtorneyDbContext> options):base(options)
        {

        }
        public DbSet<Attorney> Attorneys { get; set; }
        public DbSet<Address> Address { get; set; }


    }
}
