using System;
using System.Collections.Generic;
using System.Text;

namespace Estapar.Domain
{
    public class ManobristaService : BaseService<Manobrista>, IManobristaService
    {
        private readonly IManobristaRepository _manobristaRepository;

        public ManobristaService(IManobristaRepository manobristaRepository)
            : base(manobristaRepository)
        {
            _manobristaRepository = manobristaRepository;
        }
    }
}
