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

        public CarroManobrista VerificarCarroCreate(int idCarro)
        {
            return _carroManobristaRepository.VerificarCarroCreate(idCarro);
        }

        public CarroManobrista VerificarCarroEdit(int id, int IdCarro)
        {
            return _carroManobristaRepository.VerificarCarroEdit(id, IdCarro);
        }

        public bool VerificarCarroManobrista(int id)
        {
            return _carroManobristaRepository.VerificarCarroManobrista(id);
        }
    }
}
