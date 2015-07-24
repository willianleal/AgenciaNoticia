using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgenciaNoticias.Models
{
    [Table("Secao")]
    public class Secao
    {
        [Key]
        [Column(Order = 0)]
        public int codSecao { get; set; }

        [Display(Name = "Seção")]
        [Required(ErrorMessage = "Digite o nome da seção."), Column(Order = 1)]
        [MinLength(4, ErrorMessage = "O tamanho mínimo da seção são 4 caracteres.")]
        [StringLength(50, ErrorMessage = "O tamanho máximo da seção são 50 caracteres.")]
        public string nome { get; set; }

        [Display(Name = "Gerente")]
        [Required(ErrorMessage = "Selecione a pessoa."), Column(Order = 2)]
        public int codPessoa_Gerente { get; set; }

        [Display(Name = "Data Cadastro")]
        [Required, Column(Order = 3)]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime dataCadastro { get; set; }

        [ForeignKey("codPessoa_Gerente")]
        public virtual Pessoa Pessoa { get; set; }
    }
} 