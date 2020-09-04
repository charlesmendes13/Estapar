using System;
using System.Collections.Generic;
using System.Text;

namespace Estapar.Domain
{
    public interface ICarroManobristaRepository : IBaseRepository<CarroManobrista>
    {
        CarroManobrista VericiarCarro(int idCarro);
    }
}
