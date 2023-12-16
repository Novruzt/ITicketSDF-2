using ITicket.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITicket.Entity.Entities
{
    public class Ticket:BaseEntity
    {
        public double Price { get; set; }
        public EventType TicketType { get; set; }
        public DateTime EventDate { get; set; } 
    }
}
