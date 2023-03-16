using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace MPDVenda.Model.Enums.Endereco
{
    [Table(nameof(UnidadeFederacao))]
    public class UnidadeFederacao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(2)]
        public string Uf { get; set; }

        [Required]
        [StringLength(30)]
        public string Estado { get; set; }

        [Required]
        [StringLength(2)]
        public string CodigoIbge { get; set; }

        #region NAVEGAÇÃO
        public ICollection<Cidade> Cidade { get; set; }

        #endregion

    }
}
