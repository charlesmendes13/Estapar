using Estapar.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estapar.Application
{
    public class CarroManobristaAppService : BaseAppService<CarroManobrista>, ICarroManobristaAppService
    {
        public readonly ICarroManobristaService _carroManobristaService;

        public CarroManobristaAppService(ICarroManobristaService carroManobristaService)
            : base (carroManobristaService)
        {
            _carroManobristaService = carroManobristaService;
        }
    }
}
