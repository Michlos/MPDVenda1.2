using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPDVenda.Model.Enums.ParceiroNegocio
{
    [Table(nameof(TipoPessoa))]
    public class TipoPessoa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(2)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(20)]
        public string Descricao { get; set; }
    }
}
