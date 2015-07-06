﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgenciaNoticias.Models
{
    [Table("Materia")]
    public class Materia
    {
        [Key]
        [Column(Order = 0)]
        public int codMateria { get; set; }

        [Required, Column(Order = 1)]
        public int codPessoa_Jornalista { get; set; }

        [ForeignKey("codPessoa_Jornalista")]
        public virtual Pessoa Jornalista { get; set; }

        [Column(Order = 2)]
        public int codPessoa_Revisor { get; set; }

        [ForeignKey("codPessoa_Revisor")]
        public virtual Pessoa Revisor { get; set; }

        [Column(Order = 3)]
        public int codPessoa_Publicador { get; set; }

        [ForeignKey("codPessoa_Publicador")]
        public virtual Pessoa Publicador { get; set; }

        [Required(ErrorMessage = "Digite o nome da matéria."), Column(Order = 4)]
        [MinLength(5, ErrorMessage = "O tamanho mínimo do nome da matéria são 5 caracteres.")]
        [StringLength(100, ErrorMessage = "O tamanho máximo do nome da metéria são 100 caracteres.")]
        public string nome { get; set; }

        [Required(ErrorMessage = "Digite a matéria."), Column(Order = 5)]
        [MinLength(200, ErrorMessage = "O tamanho mínimo da matéria são 200 caracteres.")]
        public string materia { get; set; }

        [Required, Column(Order = 6)]
        public int codSessao { get; set; }

        [ForeignKey("codSessao")]
        public virtual Secao Secao { get; set; }

        [Required, Column(Order = 7)]
        public string status { get; set; }

        [Required, Column(Order = 8)]
        public DateTime dataCadastro { get; set; }
    }
}