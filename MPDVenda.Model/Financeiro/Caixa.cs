using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPDVenda.Model.Financeiro
{
    [Table(nameof(Caixa))]
    public class Caixa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime DataRegistro { get; set; } = DateTime.Now;
        public double SaldoAnterior { get; set; }
        public double SaldoAtual { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime DataFechamento { get; set; }
        public bool Fechado { get; set; } = false;

        #region NAVEGAÇÃO
        public ICollection<MovimentoCaixa> MovimentosCaixa { get; set; }

        #endregion
    }
}
