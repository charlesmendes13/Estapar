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

        public Manobrista VerificarCpf(string cpf)
        {
            return _context.Manobrista.FirstOrDefault(x => x.Cpf == cpf);
        }
    }
}
