using System;
using System.Collections.Generic;
using System.Text;

namespace Estapar.Domain
{
    public class CarroManobradoService : BaseService<CarroManobrista>, ICarroManobristaService
    {
        private readonly ICarroManobristaRepository _carroManobristaRepository;

        public CarroManobradoService(ICarroManobristaRepository carroManobristaRepository)
            : base(carroManobristaRepository)
        {
            _carroManobristaRepository = carroManobristaRepository;
        }
    }
}
