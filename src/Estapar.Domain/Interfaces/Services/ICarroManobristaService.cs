using System;
using System.Collections.Generic;
using System.Text;

namespace Estapar.Domain
{
    public interface ICarroManobristaService : IBaseService<CarroManobrista>
    {
        CarroManobrista VericiarCarro(int idCarro);        
    }
}
