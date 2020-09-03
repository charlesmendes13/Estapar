using Estapar.Domain;
using System;
using System.Collections.Generic;
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
    }
}
