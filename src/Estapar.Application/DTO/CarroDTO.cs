using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Estapar.Application
{
    public class CarroDTO : BaseDTO
    {
        [Required(ErrorMessage = "A Marca não pode ser nula")]
        [MaxLength(255)]
        [RegularExpression(@"^[ a-zA-Z á]*$", ErrorMessage = "Digite uma Marca válida")]
        [Display(Name = "Marca")]
        public string Marca { get; set; }

        [Required(ErrorMessage = "O Modelo não pode ser nulo")]
        [MaxLength(255)]
        [RegularExpression(@"^[ a-zA-Z á]*$", ErrorMessage = "Digite um Modelo válido")]
        [Display(Name = "Modelo")]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "A Placa não pode ser nula")]
        [MaxLength(8)]
        [RegularExpression(@"[A-Z]{3}\ [0-9][0-9A-Z][0-9]{2}", ErrorMessage = "Digite uma Placa Mercosul válida")]
        [Display(Name = "Placa")]
        public string Placa { get; set; }
    }
}
