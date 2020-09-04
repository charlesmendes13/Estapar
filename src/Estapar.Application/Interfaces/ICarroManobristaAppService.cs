using Estapar.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estapar.Application
{
    public interface ICarroManobristaAppService : IBaseAppService<CarroManobrista>
    {
        CarroManobrista VericiarCarro(int idCarro);

        List<CarroManobristaDTO> ListarCarrosManobrista();

        CarroManobristaDTO CarrosManobrista(int id);
    }
}
