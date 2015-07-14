using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgenciaNoticias.Models
{
    [Table("Comentario")]
    public class Comentario
    {
        [Key]
        [Column(Order = 0)]
        public int codMateria { get; set; }

        [ForeignKey("codMateria")]
        public virtual Materia Materia { get; set; }
        
        [Key]
        [Column(Order = 1)]
        public int codComentario { get; set; }

        [Display(Name = "Pessoa")]
        [Required, Column(Order = 2)]
        public int codPessoa { get; set; }

        // [ DatabaseGenerated ( DatabaseGeneratedOption . None )]
        // [ Column (" descricao_do_produto ", TypeName =" text ")]
        // [ NotMapped ]

        [ForeignKey("codPessoa")]
        public virtual Pessoa Pessoa { get; set; }

        [Display(Name = "Título")]
        [Required(ErrorMessage = "Digite o título."), Column(Order = 3)]
        [MinLength(5, ErrorMessage = "O tamanho mínimo do título são 5 caracteres.")]
        [StringLength(100, ErrorMessage = "O tamanho máximo do título são 100 caracteres.")]
        public string titulo { get; set; }

        [Display(Name = "Comentário")]
        [Required(ErrorMessage = "Digite o comentário."), Column(Order = 4)]
        [MinLength(20, ErrorMessage = "O tamanho mínimo do comentário são 20 caracteres.")]
        public string comentario { get; set; }

        [Display(Name = "Data Cadastro")]
        [Required, Column(Order = 5)]
        public DateTime dataCadastro { get; set; }
    }
}