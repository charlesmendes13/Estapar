using Estapar.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estapar.Infrastructure.Data
{
    public class CarroManobristaRepository : BaseRepository<CarroManobrista>, ICarroManobristaRepository
    {
        private readonly Context _context;

        public CarroManobristaRepository(Context context)
            : base(context)
        {
            _context = context;
        }        

        public CarroManobrista VericiarCarro(int idCarro)
        {
            return _context.CarroManobrista.FirstOrDefault(x => x.IdCarro == idCarro);
        }       
    }
}
