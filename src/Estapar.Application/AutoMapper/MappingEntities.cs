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

            CreateMap<ManobristaDTO, Manobrista>()
                .ForMember(dto => dto.DataNascimento, opt => opt.MapFrom(entity => Convert.ToString(entity.DataNascimento)));
            CreateMap<Manobrista, ManobristaDTO>()
                .ForMember(entity => entity.DataNascimento, opt => opt.MapFrom(dto => dto.DataNascimento.ToString("dd/MM/yyyy")));

            CreateMap<CarroManobristaDTO, CarroManobrista>();
            CreateMap<CarroManobrista, CarroManobristaDTO>();
        }
    }
}
