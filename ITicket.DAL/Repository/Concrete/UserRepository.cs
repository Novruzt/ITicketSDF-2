using ITicket.DAL.Repository.Abstract;
using ITicket.Entity.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITicket.DAL.Repository.Concrete
{
    public class UserRepository : BaseRepository<User>
    {
    }
}
