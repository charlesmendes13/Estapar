using System;
using System.Collections.Generic;
using System.Text;

namespace Estapar.Domain
{
    public interface IManobristaRepository : IBaseRepository<Manobrista>
    {
        Manobrista VerificarCpf(string cpf);
    }
}
