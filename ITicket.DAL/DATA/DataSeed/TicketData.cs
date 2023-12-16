using ITicket.Entity.Entities;
using ITicket.Entity.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITicket.DAL.DATA.DataSeed
{
    public static  class TicketData
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ticket>().HasData(
                new Ticket() 
                {
                    Id= 1,
                    CreationTime = DateTime.Now,
                    EventDate = DateTime.Now.AddDays(30),
                    Name="UCL final",
                    TicketType=EventType.Sport,
                    Price=50
                },
                 new Ticket()
                 {
                     Id = 2,
                     CreationTime = DateTime.Now,
                     EventDate = DateTime.Now.AddDays(10),
                     Name = "Selena",
                     TicketType = EventType.Concert,
                     Price = 100
                 },
                  new Ticket()
                  {
                      Id = 3,
                      CreationTime = DateTime.Now,
                      EventDate = DateTime.Now.AddDays(15),
                      Name = "TedX",
                      TicketType = EventType.Science,
                      Price = 25
                  }
            );
        }
    }
}
