using Estapar.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estapar.Application
{
    public interface ICarroManobristaAppService : IBaseAppService<CarroManobrista>
    {
        CarroManobrista VerificarCarrCreate(int idCarro);

        CarroManobrista VerificarCarroEdit(int id, int IdCarro);

        List<CarroManobristaDTO> ListarCarroManobrista();

        CarroManobristaDTO CarroManobrista(int id);
    }
}
