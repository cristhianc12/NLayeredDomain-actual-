using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Core;
using AutoMapper;

namespace Util.IoC.Mappers
{
    public sealed class MapperInitializer
    {
        public static void ConfigureMapping()
        {
            Mapper.Initialize(map =>
            {
                map.AddProfile<MapperProfile>();
            }
            );
        }
    }
}
