using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Agenda_Telefonica.Models
{
    [Table("Contatos")]
    public class Contatos
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Por Favor, Informe seu Nome.")]
        [Display(Name = "Nome")]
        [StringLength(50)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Por Favor, Informe seu Endereço.")]
        [Display(Name = "Endereço")]
        [StringLength(50)]
        public string Endereco { get; set; }


        [Required(ErrorMessage = "Por Favor, Informe seu Telefone.")]
        [Display(Name = "Telefone")]
        [StringLength(20)]
        public string Telefone { get; set; }

    }
}
