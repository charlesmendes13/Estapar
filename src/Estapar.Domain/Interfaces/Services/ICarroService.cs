using System;
using System.Collections.Generic;
using System.Text;

namespace Estapar.Domain
{
    public interface ICarroService : IBaseService<Carro>
    {
        Carro VerificarPlaca(string placa);
    }
}
