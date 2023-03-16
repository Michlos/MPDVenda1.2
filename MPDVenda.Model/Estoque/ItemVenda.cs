using MPDVenda.Model.Enums.ItemVenda;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPDVenda.Model.Estoque
{
    [Table(nameof(ItemVenda))]
    public class ItemVenda
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(10)]
        [Required(ErrorMessage = "Código do Item é obrigatório!")]
        public string Codigo { get; set; }

        [StringLength(20)]
        public string BarCode { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Descrição do produto é obrigatório")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Data de registro do item é obrigatório")]
        public DateTime DataRegistro { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Data da última alteração é obrigatório")]
        public DateTime DataUltimaAlteração { get; set; }
        public double EstoqueAtual { get; set; }
        public double PrevSaida { get; set; }
        public bool Ativo { get; set; } = true;
        public bool Bloqueado { get; set; } = false;
        public double PrecoCompra { get; set; }
        public double PrecoVenda { get; set; }
        public double Margem { get; set; }

        #region CHAVES ESTRANGEIRAS

        [ForeignKey(nameof(TipoItem))]
        public int TipoItemId { get; set; }
        public virtual TipoItem TipoItem { get; set; }

        #endregion

        #region NAVEGAÇÃO
        public ICollection<PrecoItem> PrecosItem { get; set; }

        #endregion
    }
}
