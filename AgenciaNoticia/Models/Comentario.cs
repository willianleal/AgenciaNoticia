using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgenciaNoticias.Models
{
    public class Comentario
    {
        [Key]
        [Column(Order = 0)]
        public int codMateria { get; set; }
        [Key]
        [Column(Order = 1)]
        public int codComentario { get; set; }
        public int codPessoa { get; set; }
        public string titulo { get; set; }
        public string comentario { get; set; }
        public DateTime dataCadastro { get; set; }
    }
}