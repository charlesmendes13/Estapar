using Estapar.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estapar.Application
{
    public class ManobristaAppService : BaseAppService<Manobrista>, IManobristaAppService
    {
        public readonly IManobristaService _manobristaService;

        public ManobristaAppService(IManobristaService manobristaService)
            : base(manobristaService)
        {
            _manobristaService = manobristaService;
        }

        public Manobrista VerificarCpfCreate(string cpf)
        {
            return _manobristaService.VerificarCpfCreate(cpf);
        }

        public Manobrista VerificarCpfEdit(int id, string cpf)
        {
            return _manobristaService.VerificarCpfEdit(id, cpf);
        }
    }
}
