using Estapar.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estapar.Infrastructure.Data
{
    public class CarroRepository : BaseRepository<Carro>, ICarroRepository
    {
        private readonly Context _context;

        public CarroRepository(Context context)
            : base(context)
        {
            _context = context;
        }

        public Carro VerificarPlaca(string placa)
        {
            return _context.Carro.FirstOrDefault(x => x.Placa == placa);
        }
    }
}
