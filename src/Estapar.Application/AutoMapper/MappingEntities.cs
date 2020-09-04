using AutoMapper;
using Estapar.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estapar.Application
{
    public class MappingEntities : Profile
    {
        public MappingEntities()
        {
            CreateMap<CarroDTO, Carro>();
            CreateMap<Carro, CarroDTO>();

            CreateMap<ManobristaDTO, Manobrista>();
            CreateMap<Manobrista, ManobristaDTO>();

            CreateMap<CarroManobristaDTO, CarroManobrista>();
            CreateMap<CarroManobrista, CarroManobristaDTO>();           
        }
    }
}
