using System;
using System.Collections.Generic;
using System.Text;

namespace Estapar.Domain
{
    public interface IManobristaRepository : IBaseRepository<Manobrista>
    {
        Manobrista VerificarCpfCreate(string cpf);

        Manobrista VerificarCpfEdit(int id, string cpf);
    }
}
