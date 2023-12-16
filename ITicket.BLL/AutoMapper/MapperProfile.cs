using AutoMapper;
using ITicket.BLL.DTOs.UserDTOs;
using ITicket.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITicket.BLL.AutoMapper
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<UserLoginDTO, User>();
        }
    }
}
