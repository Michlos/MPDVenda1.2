using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPDVenda.Model.Enums.Endereco
{
    [Table(nameof(Bairro))]
    public class Bairro
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(300)]
        public string Nome { get; set; }

        #region CHAVES ESTRANGEIRAS

        [ForeignKey(nameof(Cidade))]
        public int CidadeId { get; set; }
        public virtual Cidade Cidade { get; set; }

        #endregion

    }
}
