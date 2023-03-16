using MPDVenda.Model.Enums.Financeiro;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPDVenda.Model.Financeiro
{
    [Table(nameof(MovimentoCaixa))]
    public class MovimentoCaixa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Valor da movimentação é obrigatório!")]
        public double Valor { get; set; }

        [StringLength(1000)]
        [Required(ErrorMessage = "Histórico da movimentação é obrigatório!")]
        public string Historico { get; set; }

        public DateTime DataMovimento { get; set; } = DateTime.Now;
        public bool Cancelado { get; set; } = false;

        [ForeignKey(nameof(PartidaDobrada))]
        public int PartidaDobradaId { get; set; }
        public virtual PartidaDobrada PartidaDobrada { get; set; }

        #region CHAVES ESTRANGEIRAS

        [ForeignKey(nameof(Caixa))]
        public int CaixaId { get; set; }
        public virtual Caixa Caixa { get; set; }

        #endregion
    }
}