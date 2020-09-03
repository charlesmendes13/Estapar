using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Estapar.Domain
{
    [Table("CarroManobrista")]
    public class CarroManobrista : Base
    {       
        [Column("Carro")]
        [ForeignKey("Carro")]
        public virtual int IdCarro { get; set; }
        public virtual Carro Carro { get; set; }

        [Column("Manobrista")]
        [ForeignKey("Manobrista")]
        public virtual int IdManobrista { get; set; }
        public virtual Manobrista Manobrista { get; set; }
    }
}
