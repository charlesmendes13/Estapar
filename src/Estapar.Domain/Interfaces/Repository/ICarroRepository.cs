using System;
using System.Collections.Generic;
using System.Text;

namespace Estapar.Domain
{
    public interface ICarroRepository : IBaseRepository<Carro>
    {
        Carro VerificarPlacaCreate(string placa);

        Carro VerificarPlacaEdit(int id, string placa);

        bool VerificarCarro(int id);
    }
}
