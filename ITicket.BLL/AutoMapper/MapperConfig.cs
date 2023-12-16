using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITicket.BLL.AutoMapper
{
    using AutoMapper;

    public static class MapperConfig
    {
        private static IMapper _mapper;

        public static void Initialize()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MapperProfile>();
            });

            _mapper = config.CreateMapper();
        }

        public static IMapper MapperInstance
        {
            get
            {
                if (_mapper == null)
                {
                    Initialize();
                }

                return _mapper;
            }
        }
    }
}
