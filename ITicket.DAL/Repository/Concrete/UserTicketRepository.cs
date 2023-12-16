using ITicket.DAL.DATA;
using ITicket.DAL.Repository.Abstract;
using ITicket.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ITicket.DAL.Repository.Concrete
{
    public class UserTicketRepository:BaseRepository<UserTicket>
    { 
        public override void Update(UserTicket entity)
        {
            UserTicket userTicket = FirstOrDefault(ut=>ut.TicketId == entity.TicketId && ut.UserId==entity.UserId);
            if (userTicket != null) 
            {
                userTicket.Number=entity.Number;
            }

            Save();
        }
    }
}
