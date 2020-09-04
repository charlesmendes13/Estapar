using Estapar.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estapar.Application
{
    public class CarroAppService : BaseAppService<Carro>, ICarroAppService
    {
        public readonly ICarroService _carroService;

        public CarroAppService(ICarroService carroService)
            : base(carroService)
        {
            _carroService = carroService;
        }

        public Carro VerificarPlaca(string placa)
        {
            return _carroService.VerificarPlaca(placa);
        }
    }
}
