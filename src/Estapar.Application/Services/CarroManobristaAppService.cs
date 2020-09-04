using Estapar.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estapar.Application
{
    public class CarroManobristaAppService : BaseAppService<CarroManobrista>, ICarroManobristaAppService
    {
        public readonly ICarroManobristaService _carroManobristaService;
        public readonly ICarroService _carroService;
        public readonly IManobristaService _manobristaService;

        public CarroManobristaAppService(ICarroManobristaService carroManobristaService,
            ICarroService carroService,
            IManobristaService manobristaService)
            : base (carroManobristaService)
        {
            _carroManobristaService = carroManobristaService;
            _carroService = carroService;
            _manobristaService = manobristaService;
        }        

        public CarroManobrista VericiarCarro(int idCarro)
        {
            return _carroManobristaService.VericiarCarro(idCarro);
        }

        public List<CarroManobristaDTO> ListarCarrosManobrista()
        {
            return (from carroManobristas in _carroManobristaService.Get().ToList()
                    join carros in _carroService.Get().ToList() on carroManobristas.IdCarro equals carros.Id
                    join manobristas in _manobristaService.Get().ToList() on carroManobristas.IdManobrista equals manobristas.Id                   
                    select new CarroManobristaDTO()
                    {
                        Id = carroManobristas.Id,
                        Modelo = carros.Modelo,
                        Placa = carros.Placa,
                        Nome = manobristas.Nome,
                        Cpf = manobristas.Cpf
                    })
                    .ToList();
        }

        public CarroManobristaDTO CarrosManobrista(int id)
        {
            return (from carroManobristas in _carroManobristaService.Get().ToList()
                    join carros in _carroService.Get().ToList() on carroManobristas.IdCarro equals carros.Id
                    join manobristas in _manobristaService.Get().ToList() on carroManobristas.IdManobrista equals manobristas.Id
                    where carroManobristas.Id == id
                    select new CarroManobristaDTO()
                    {
                        Id = carroManobristas.Id,
                        Modelo = carros.Modelo,
                        Placa = carros.Placa,
                        Nome = manobristas.Nome,
                        Cpf = manobristas.Cpf
                    })
                    .FirstOrDefault();
        }
    }
}
