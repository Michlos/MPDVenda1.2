using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPDVenda.Model.Estoque
{
    [Table(nameof(PrecoItem))]
    public class PrecoItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Preço de Compra é obrigatório")]
        public double PrecoCompra { get; set; }

        [Required(ErrorMessage = "Preço de Venda é obrigatório")]
        public double PrecoVenda { get; set; }

        [Required(ErrorMessage = "Margem é obrigatório")]
        public double Margem { get; set; }

        [Required(ErrorMessage = "Data de Registro de Preço é obrigatório")]
        public DateTime DataRegistro { get; set; }
        public bool Ativo { get; set; } = true;

        #region CHAVES ESTRANGEIRAS

        [ForeignKey(nameof(ItemVenda))]
        public int ItemVendaId { get; set; }
        public virtual ItemVenda ItemVenda { get; set; }
        
        #endregion
    }
}