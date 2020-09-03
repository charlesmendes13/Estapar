using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Estapar.Domain
{
    [Table("Manobrista")]
    public class Manobrista : Base
    {
        [Required]
        [Column("Nome")]
        public virtual string Nome { get; set; }

        [Required]
        [Column("CPF")]
        public virtual string Cpf { get; set; }

        [Required]
        [Column("Data_Nascimento")]
        public virtual DateTime DataNascimento { get; set; }

        public virtual ICollection<CarroManobrista> CarroManobrista { get; set; }
    }
}
