using Estapar.Domain;
using Microsoft.EntityFrameworkCore;
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

        public CarroManobrista VerificarCarrCreate(int idCarro)
        {
            return _context.CarroManobrista.FirstOrDefault(x => x.IdCarro == idCarro);
        }

        public CarroManobrista VerificarCarroEdit(int id, int IdCarro)
        {
            return _context.CarroManobrista.FirstOrDefault(x => x.Id != id && x.IdCarro == IdCarro);
        }
    }
}
