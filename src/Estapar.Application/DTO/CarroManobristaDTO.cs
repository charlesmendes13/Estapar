using System;
using System.Collections.Generic;
using System.Text;

namespace Estapar.Application
{
    public class CarroManobristaDTO : BaseDTO
    {
        public int? IdCarro { get; set; }

        public string Modelo { get; set; }

        public string Placa { get; set; }
        
        public int? IdManobrista { get; set; }

        public string Nome { get; set; }

        public string Cpf { get; set; }
    }
}
