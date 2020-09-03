using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Estapar.Application
{
    public class CarroDTO
    {
        [Required]
        [MaxLength(255)]
        [RegularExpression(@"^[ a-zA-Z á]*$", ErrorMessage = "Digite uma Marca válida")]
        [Display(Name = "Marca")]
        public string Marca { get; set; }

        [Required]
        [MaxLength(255)]
        [RegularExpression(@"^[ a-zA-Z á]*$", ErrorMessage = "Digite um Modelo válido")]
        [Display(Name = "Modelo")]
        public string Modelo { get; set; }

        [Required]
        [MaxLength(7)]
        [RegularExpression(@"[A-Z]{3}\ [0-9][0-9A-Z][0-9]{2}", ErrorMessage = "Digite uma Placa Mercosul válida")]
        [Display(Name = "Placa")]
        public string Placa { get; set; }
    }
}
