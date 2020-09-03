using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Estapar.Application
{
    public class ManobristaDTO
    {
        [Required]
        [MaxLength(255)]
        [RegularExpression(@"^[ a-zA-Z á]*$", ErrorMessage = "Digite um Nome válido")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required]
        [MaxLength(14)]
        [RegularExpression(@"[0-9]{3}\.[0-9]{3}\.[0-9]{3}-[0-9]{2}", ErrorMessage = "Digite um CPF válido")]
        [Display(Name = "CPF")]
        public string Cpf { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data Nascimento")]
        public string DataNascimento { get; set; }
    }
}
