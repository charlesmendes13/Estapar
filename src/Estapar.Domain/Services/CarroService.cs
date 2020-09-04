using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estapar.Domain
{
    public class CarroService : BaseService<Carro>, ICarroService
    {
        private readonly ICarroRepository _carroRepository;

        public CarroService(ICarroRepository carroRepository)
            : base(carroRepository)
        {
            _carroRepository = carroRepository;
        }

        public Carro VerificarPlaca(string placa)
        {
            return _carroRepository.VerificarPlaca(placa);
        }
    }
}
