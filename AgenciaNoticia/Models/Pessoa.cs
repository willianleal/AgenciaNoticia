using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgenciaNoticias.Models
{
    [Table("Pessoa")]
    public class Pessoa
    {
        [Key]
        [Column(Order = 0)]
        public int codPessoa { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Digite o nome da pessoa."), Column(Order = 1)]
        [MinLength(2, ErrorMessage = "O tamanho mínimo do nome são 2 caracteres.")]
        [StringLength(50, ErrorMessage = "O tamanho máximo do nome são 50 caracteres.")]
        public string nome { get; set; }

        [Display(Name = "Função")]
        [Required(ErrorMessage = "Selecione a função."), Column(Order = 2)]
        public string funcao { get; set; }

        [Display(Name = "DDD")]
        [Required(ErrorMessage = "Digite o DDD."), Column(Order = 3)]
        [MinLength(2, ErrorMessage = "O tamanho mínimo do DDD são 2 caracteres.")]
        [StringLength(2, ErrorMessage = "O tamanho máximo do DDD são 2 caracteres.")]
        public string ddd { get; set; }

        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "Digite o telefone."), Column(Order = 4)]
        [MinLength(8, ErrorMessage = "O tamanho mínimo do telefone são 8 caracteres.")]
        [StringLength(9, ErrorMessage = "O tamanho máximo do telefone são 9 caracteres.")]
        public string telefone { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Digite o email."), Column(Order = 5)]
        [StringLength(50, ErrorMessage = "O tamanho máximo do email são 50 caracteres.")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email inválido.")]
        public string email { get; set; }

        [Display(Name = "Ativo")]
        [Required, Column(Order = 6)]
        public bool ativo { get; set; }

        [Display(Name = "Data Cadastro")]
        [Required, Column(Order = 7)]
        public DateTime dataCadastro { get; set; }

        [Display(Name = "Senha")]
        [Required(ErrorMessage = "Digite a senha."), Column(Order = 8)]
        [MinLength(8, ErrorMessage = "O tamanho mínimo da senha são 8 caracteres.")]
        [StringLength(50, ErrorMessage = "O tamanho máximo da senha são 50 caracteres.")]
        public string senha { get; set; }

        public virtual List<Secao> Secoes { get; set; }
    }
}