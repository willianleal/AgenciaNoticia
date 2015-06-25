using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgenciaNoticias.Models
{
    public class Pessoa
    {
        [Key]
        public int codPessoa { get; set; }
        public string nome { get; set; }
        public int funcao { get; set; }
        public string ddd { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public string ativo { get; set; }
        public DateTime dataCadastro { get; set; }
        public string senha { get; set; }
    }
}