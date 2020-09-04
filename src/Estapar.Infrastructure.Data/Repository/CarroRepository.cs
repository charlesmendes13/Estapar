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

        public Carro VerificarPlacaCreate(string placa)
        {
            return _context.Carro.FirstOrDefault(x => x.Placa == placa);
        }

        public Carro VerificarPlacaEdit(int id, string placa)
        {
            return _context.Carro.FirstOrDefault(x => x.Id != id && x.Placa == placa);
        }
    }
}
