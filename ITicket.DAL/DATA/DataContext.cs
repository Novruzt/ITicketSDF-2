using ITicket.DAL.DATA.DataSeed;
using ITicket.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ITicket.DAL.DATA
{
    public class DataContext : DbContext
    {
        private string ConnectionString = "Server=.;Database=ITicketBMU;Integrated Security=true;TrustServerCertificate=True";
        public DataContext()
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserTicket>()
           .HasKey(ut => new { ut.UserId, ut.TicketId });

            modelBuilder.Entity<UserTicket>().Ignore(ut=>ut.Id);

            TicketData.Seed(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionString);
            }

            base.OnConfiguring(optionsBuilder);
        }
        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries<BaseEntity>())
            {
                if (entry.State == EntityState.Deleted)
                {
                   
                        entry.State = EntityState.Modified;
                        entry.Entity.DeleteTime = DateTime.Now;
                        entry.Entity.IsDeleted = true;

                        if (entry.Entity.IsDeleted == false && entry.OriginalValues["IsDeleted"] as bool? == true)
                        {
                            entry.Entity.UpdateTime = null;
                            entry.Entity.CreationTime = DateTime.Now;
                            entry.Entity.DeleteTime = null;
                        }
                }
                else
                {

                    _ = entry.State switch
                    {
                        EntityState.Added => entry.Entity.CreationTime = DateTime.Now,
                        EntityState.Modified => entry.Entity.UpdateTime = DateTime.Now,
                        _ => DateTime.Now
                    };

                    if (entry.State == EntityState.Modified)
                    {
                        if (entry.Entity.IsDeleted == false && entry.OriginalValues["IsDeleted"] as bool? == true)
                        {
                            entry.Entity.UpdateTime = null;
                            entry.Entity.CreationTime = DateTime.Now;
                            entry.Entity.DeleteTime = null;
                        }
                    }
                }
            }

            return base.SaveChanges();
        }
        public DbSet<User> Users { get; set; }
       public DbSet<Ticket> Tickets { get; set; }
       public DbSet<UserTicket> UserTickets { get; set; }
    }
}
