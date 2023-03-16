using MPDVenda.Model.Enums.ParceiroNegocio;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPDVenda.Model.ParceiroNegocio
{
    [Table(nameof(Parceiro))]
    public class Parceiro
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Data de Registro do Parceiro de Negócios é obrigatório!")]
        public DateTime DataRegistro { get; set; } = DateTime.Now;

        [StringLength(100)]
        [Required(ErrorMessage = "Nome Fantasia é campo obrigatório!")]
        public string NomeFantasia { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Razão Social é campo obrigatório!")]
        public string RazaoSocial { get; set; }

        [StringLength(14)]
        public string Cpf { get; set; }

        [StringLength(18)]
        public string Cnpj { get; set; }

        [StringLength(18)]
        public string Rg { get; set; }

        public DateTime DataNascimento { get; set; }
        public DateTime DataFundacao { get; set; }

        [StringLength(300)]
        [Required(ErrorMessage = "Email de Faturamento é campo obrigatório!")]
        public string EmailFaturamento { get; set; }

        [StringLength(300)]
        public string EmailMarketing { get; set; }
        public DateTime DataUltimaCompra { get; set; }
        public bool Ativo { get; set; } = true;
        public bool Bloqueado { get; set; } = false;
        public bool Removido { get; set; } = false;


        #region CHAVES ESTRANGEIRAS
        [ForeignKey(nameof(TipoParceiro))]
        public int TipoParceiroId { get; set; }
        public virtual TipoParceiro TipoParceiro { get; set; }

        [ForeignKey(nameof(TipoPessoa))]
        public int TipoPessoaId { get; set; }
        public virtual TipoPessoa TipoPessoa { get; set; }

        #endregion

        #region NAVEGAÇÃO
        public ICollection<Endereco> Enderecos { get; set; }

        #endregion
    }
}
