using Estapar.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estapar.Application
{
    public interface ICarroManobristaAppService : IBaseAppService<CarroManobrista>
    {
        List<CarroManobristaDTO> ListarCarroManobrista();

        CarroManobristaDTO CarroManobrista(int id);

        CarroManobrista VerificarCarroCreate(int idCarro);

        CarroManobrista VerificarCarroEdit(int id, int IdCarro);

        bool VerificarCarroManobrista(int id);        
    }
}
