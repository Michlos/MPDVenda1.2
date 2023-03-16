using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPDVenda.Model.Enums.ItemVenda
{
    [Table(nameof(TipoMovimentacaoEstoque))]
    public class TipoMovimentacaoEstoque
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string Descricao { get; set; }

        [Required]
        public bool Incrementa { get; set; }
    }
}
