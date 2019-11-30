using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI.Models
{
    public class Pessoa
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [Required]
        [MaxLength(50)]
        public String Nome { get; set; }
        [Required]
        [MaxLength(11)]
        public String Cpf { get; set; }
        [MaxLength(11)]
        public String Telefone { get; set; }
        [MaxLength(50)]
        public String Email { get; set; }
    }
}
