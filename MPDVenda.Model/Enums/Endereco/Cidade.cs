using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPDVenda.Model.Enums.Endereco
{
    [Table(nameof(Cidade))]
    public class Cidade
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(300)]
        public string Nome { get; set; }

        [Required]
        [StringLength(10)]
        public string CodigoIbge { get; set; }

        #region CHAVES ESTRANGEIRAS

        [ForeignKey(nameof(UnidadeFederacao))]
        public int UfId { get; set; }
        public virtual UnidadeFederacao UnidadeFederacao { get; set; }

        #endregion

        #region NAVEGAÇÃO
        public ICollection<Bairro> Bairros { get; set; }

        #endregion


    }
}
