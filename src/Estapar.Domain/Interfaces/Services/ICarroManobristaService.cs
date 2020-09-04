using System;
using System.Collections.Generic;
using System.Text;

namespace Estapar.Domain
{
    public interface ICarroManobristaService : IBaseService<CarroManobrista>
    {
        CarroManobrista VerificarCarroCreate(int idCarro);

        CarroManobrista VerificarCarroEdit(int id, int IdCarro);

        bool VerificarCarroManobrista(int id);
    }
}
