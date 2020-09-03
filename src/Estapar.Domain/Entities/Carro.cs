using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Estapar.Domain
{
    [Table("Carro")]
    public class Carro : Base
    {
        [Required]
        [Column("Marca")]
        public virtual string Marca { get; set; }

        [Required]
        [Column("Modelo")]
        public virtual string Modelo { get; set; }

        [Required]
        [Column("Placa")]
        public virtual string Placa { get; set; }

        public virtual ICollection<CarroManobrista> CarroManobrista { get; set; }
    }
}
