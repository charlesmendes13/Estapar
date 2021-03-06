﻿using Estapar.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estapar.Application
{
    public interface ICarroAppService : IBaseAppService<Carro>
    {
        Carro VerificarPlacaCreate(string placa);

        Carro VerificarPlacaEdit(int id, string placa);

        bool VerificarCarro(int id);
    }
}
