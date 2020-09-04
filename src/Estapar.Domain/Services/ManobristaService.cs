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

        public Manobrista VerificarCpfCreate(string cpf)
        {
            return _manobristaRepository.VerificarCpfCreate(cpf);
        }

        public Manobrista VerificarCpfEdit(int id, string cpf)
        {
            return _manobristaRepository.VerificarCpfEdit(id, cpf);
        }

        public bool VerificarManobrista(int id)
        {
            return _manobristaRepository.VerificarManobrista(id);
        }
    }
}
