using System;
using System.Collections.Generic;
using System.Text;

namespace Estapar.Domain
{
    public interface IManobristaService : IBaseService<Manobrista>
    {
        Manobrista VerificarCpfCreate(string cpf);

        Manobrista VerificarCpfEdit(int id, string cpf);

        bool VerificarManobrista(int id);
    }
}
