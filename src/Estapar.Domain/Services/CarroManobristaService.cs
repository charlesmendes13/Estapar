﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Estapar.Domain
{
    public class CarroManobristaService : BaseService<CarroManobrista>, ICarroManobristaService
    {
        private readonly ICarroManobristaRepository _carroManobristaRepository;

        public CarroManobristaService(ICarroManobristaRepository carroManobristaRepository)
            : base(carroManobristaRepository)
        {
            _carroManobristaRepository = carroManobristaRepository;
        }        

        public CarroManobrista VericiarCarro(int idCarro)
        {
            return _carroManobristaRepository.VericiarCarro(idCarro);
        }       
    }
}
