using System;
using System.Collections.Generic;
using System.Text;

namespace Estapar.Domain
{
    public interface ICarroService : IBaseService<Carro>
    {
        Carro VerificarPlacaCreate(string placa);

        Carro VerificarPlacaEdit(int id, string placa);

        bool VerificarCarro(int id);
    }
}
