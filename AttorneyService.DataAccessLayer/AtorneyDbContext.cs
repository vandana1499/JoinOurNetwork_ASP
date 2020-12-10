using Microsoft.EntityFrameworkCore;
using Modal;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;

namespace AttorneyService.DataAccessLayer
{
    public class AtorneyDbContext:DbContext
    {
        public AtorneyDbContext(DbContextOptions<AtorneyDbContext> options):base(options)
        {

        }
        public DbSet<AttorneyEntities> Attorneys { get; set; }
        public DbSet<AddressEntities> Address { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AttorneyEntities>(entity => {

                entity.Property(e => e.FirstName)
                .IsRequired();

                entity.Property(e => e.MiddleName);

                entity.Property(e => e.LastName)
                .IsRequired();

                entity.Property(e => e.Email)
                .IsRequired();

                entity.Property(e => e.Specialization)
                 .IsRequired();
                //entity.HasOne(d => d.AddressEntities)
                //.WithOne(p => p.attorneyEntities)
                //.HasForeignKey("hno");



            });

            modelBuilder.Entity<AddressEntities>(entity => {

                entity.Property(e => e.Lane1)
                .IsRequired();

                entity.Property(e => e.Lane2);

                entity.Property(e => e.City)
                .IsRequired();

                entity.Property(e => e.State)
                .IsRequired();

                entity.Property(e => e.Zip)
                 .IsRequired();

               


            });

        }
       


    }
}
