using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgenciaNoticias.Models
{
    public class Materia
    {
        [Key]
        public int codMateria { get; set; }
        public int codPessoa_Jornalista { get; set; }
        public int codPessoa_Revisor { get; set; }
        public int codPessoa_Publicador { get; set; }
        public string nome { get; set; }
        public string materia { get; set; }
        public string materiaRevisada { get; set; }
        public int codSessao { get; set; }
        public string status { get; set; }
        public DateTime dataCadastro { get; set; }
    }
}