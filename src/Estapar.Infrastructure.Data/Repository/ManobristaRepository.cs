using Estapar.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estapar.Infrastructure.Data
{
    public class ManobristaRepository : BaseRepository<Manobrista>, IManobristaRepository
    {
        private readonly Context _context;

        public ManobristaRepository(Context context)
            : base(context)
        {
            _context = context;
        }

        public Manobrista VerificarCpfCreate(string cpf)
        {
            return _context.Manobrista.FirstOrDefault(x => x.Cpf == cpf);
        }

        public Manobrista VerificarCpfEdit(int id, string cpf)
        {
            return _context.Manobrista.FirstOrDefault(x => x.Id != id && x.Cpf == cpf);
        }

        public bool VerificarManobrista(int id)
        {
            return _context.Manobrista.Any(e => e.Id == id);
        }
    }
}
