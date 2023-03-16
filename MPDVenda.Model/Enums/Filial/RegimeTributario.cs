using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPDVenda.Model.Enums.Filial
{
    [Table(nameof(RegimeTributario))]
    public class RegimeTributario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Required(ErrorMessage ="Código do Regime tríbutário é obrigatório!")]
        public int CodigoRegimeTributario { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage ="Descrição do Regime Tributário é obrigatório")]
        public string Descricao { get; set; }


    }
}
