using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgenciaNoticias.Models
{
    public class Secao
    {
        [Key]
        public int codSecao { get; set; }
        public string secao { get; set; }
        public int codPessoa_Gerente { get; set; }
        public DateTime dataCadastro { get; set; }
    }
}