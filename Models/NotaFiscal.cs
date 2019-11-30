using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI.Models
{
    public class NotaFiscal
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [Required]
        public long NumeroNota { get; set; }
        [Required]
        public long SerieNota { get; set; }
        [Required]
        public String ChaveNota { get; set; }
        [Required]
        public DateTime DataEmissao { get; set; }
        [Required]
        public float ValorNota { get; set; }
    }
}
