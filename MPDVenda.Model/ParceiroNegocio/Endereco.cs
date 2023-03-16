using MPDVenda.Model.Enums.Endereco;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPDVenda.Model.ParceiroNegocio
{
    [Table(nameof(Endereco))]
    public class Endereco
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(8)]
        [Required(ErrorMessage = "CEP é campo obrigatório!")]
        public string Cep { get; set; }

        [StringLength(300)]
        [Required(ErrorMessage = "Nome do Logradouro é obrigatório!")]
        public string Logradouro { get; set; }

        [StringLength(10)]
        [Required(ErrorMessage = "Número é obrigatório (SN=Sem Número)")]
        public string Numero { get; set; }

        [StringLength(300)]
        public string Complemento { get; set; }
        
        public bool Removido { get; set; } = false;

        #region CHAVES ESTRANGEIRAS

        [ForeignKey(nameof(Parceiro))]
        public int ParceiroId { get; set; }
        public virtual Parceiro Parceiro { get; set; }

        [ForeignKey(nameof(UnidadeFederacao))]
        public int UnidadeFederacaoId { get; set; }
        public virtual UnidadeFederacao UnidadeFederacao { get; set; }

        [ForeignKey(nameof(Cidade))]
        public int CidadeId { get; set; }
        public virtual Cidade Cidade { get; set; }

        [ForeignKey(nameof(Bairro))]
        public int BairroId { get; set; }
        public virtual Bairro Bairro { get; set; }

        [ForeignKey(nameof(TipoEndereco))]
        public int TipoEnderecoId { get; set; }
        public virtual TipoEndereco TipoEndereco { get; set; }

        [ForeignKey(nameof(TipoLogradouro))]
        public int TipoLogradouroId { get; set; }
        public virtual TipoLogradouro TipoLogradouro { get; set; }

        #endregion

    }
}