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

        public Carro VerificarPlacaCreate(string placa)
        {
            return _carroRepository.VerificarPlacaCreate(placa);
        }

        public Carro VerificarPlacaEdit(int id, string placa)
        {
            return _carroRepository.VerificarPlacaEdit(id, placa);
        }
    }
}
