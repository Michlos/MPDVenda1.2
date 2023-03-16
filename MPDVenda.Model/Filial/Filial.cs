using MPDVenda.Model.Enums.Endereco;
using MPDVenda.Model.Enums.Filial;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPDVenda.Model.Filial
{
    [Table(nameof(Filial))]
    public class Filial
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(300)]
        [Required(ErrorMessage = "Nome Fantasia é obrigatório!")]
        public string NomeFantasia { get; set; }

        [StringLength(300)]
        [Required(ErrorMessage = "Razão Social é obrigatório!")]
        public string RazaoSocial { get; set; }


        [StringLength(8)]
        [Required(ErrorMessage = "CEP é campo obrigatório!")]
        public string EnderecoCep { get; set; }

        [StringLength(300)]
        [Required(ErrorMessage = "Nome do Logradouro é obrigatório!")]
        public string EndrecoLogradouro { get; set; }

        [StringLength(10)]
        [Required(ErrorMessage = "Número é obrigatório (SN=Sem Número)")]
        public string EnderecoNumero { get; set; }

        [StringLength(300)]
        public string EnderecoComplemento { get; set; }

        [StringLength(18)]
        public string Cnpj { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "Inscrição Estadual é obrigatório!")]
        public string InscricaoEstadual { get; set; } = "ISENTO";

        [StringLength(30)]
        public string InscricaoMunicipal { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "CNAE é obrigatório!")]
        public string CNAE { get; set; }

        [StringLength(200)]
        [Required(ErrorMessage = "Nome do Responsável pela empresa é obrigatório!")]
        public string ResponsavelNome { get; set; }

        [StringLength(14)]
        [Required(ErrorMessage = "CPF do Responsável pela empresa é obrigatório")]
        public string ResponsavelCpf { get; set; }

        [StringLength(200)]
        public string ContadorResponsavel { get; set; }

        [StringLength(14)]
        public string ContadorCpf { get; set; }
        public bool FilialAtiva { get; set; } = true;



        #region CHAVES ESTRANGEIRAS

        [ForeignKey(nameof(TipoLogradouro))]
        public int TipoLogradouroId { get; set; }
        public virtual TipoLogradouro TipoLogradouro { get; set; }

        [ForeignKey(nameof(TipoLogradouro))]
        public int UnidadeFederacaoId { get; set; }
        public virtual UnidadeFederacao UnidadeFederacao { get; set; }

        [ForeignKey(nameof(Cidade))]
        public int CidadeId { get; set; }
        public virtual Cidade Cidade { get; set; }

        [ForeignKey(nameof(Bairro))]
        public int BairroId { get; set; }
        public virtual Bairro Bairro { get; set; }

        [ForeignKey(nameof(RegimeTributario))]
        public int RegimeTributarioId { get; set; }
        public virtual RegimeTributario RegimeTributario { get; set; }

        #endregion
    }
}
