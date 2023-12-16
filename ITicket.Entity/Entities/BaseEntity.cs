using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITicket.Entity.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; } 
        public DateTime CreationTime { get; set; }
        public DateTime? UpdateTime { get; set;}
        public DateTime? DeleteTime { get; set; }
    }
}
