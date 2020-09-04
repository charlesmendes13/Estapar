using Estapar.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estapar.Application
{
    public interface IManobristaAppService : IBaseAppService<Manobrista>
    {
        Manobrista VerificarCpfCreate(string cpf);

        Manobrista VerificarCpfEdit(int id, string cpf);

        bool VerificarManobrista(int id);
    }
}
