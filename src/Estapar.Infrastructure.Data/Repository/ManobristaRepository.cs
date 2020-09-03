using Estapar.Domain;
using System;
using System.Collections.Generic;
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
    }
}
