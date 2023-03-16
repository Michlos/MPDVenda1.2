using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPDVenda.Model.Enums.Financeiro
{
    [Table(nameof(PartidaDobrada))]
    public class PartidaDobrada
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(1)]
        public char Codigo { get; set; }

        [Required]
        [StringLength(10)]
        public string Descricao { get; set; }

        [Required]
        public bool Incrementa { get; set; }

    }
}
