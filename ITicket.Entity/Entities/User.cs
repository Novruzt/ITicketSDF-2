using ITicket.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITicket.Entity.Entities
{
    public class User : BaseEntity
    {
        public UserRole UserRole { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<UserTicket> UserTickets { get; set; }
    }
}
