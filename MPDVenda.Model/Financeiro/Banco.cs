using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPDVenda.Model.Financeiro
{
    [Table(nameof(Banco))]
    public class Banco
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Data de Registro do Banco deve ser informado automaticamente pelo sistema. Entre em contato com o Administrador!")]
        public DateTime DataRegistro { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Número do Código do Banco é obrigatório!")]
        public int Codigo { get; set; }

        [StringLength(200)]
        [Required(ErrorMessage = "Nome do Banco é obrigatório!")]
        public string Nome { get; set; }

        [StringLength(10)]
        [Required(ErrorMessage = "Número da Agência é obrigatório!")]
        public string Agencia { get; set; }

        [StringLength(2)]
        public string AgenciaDv { get; set; }

        [StringLength(20)]
        [Required(ErrorMessage = "Número da Conta Bancária é obrigatório!")]
        public string Conta { get; set; }

        [StringLength(2)]
        [Required(ErrorMessage = "Número do Dígito Verificador da Conta é obrigatório!")]
        public string ContaDv { get; set; }

        [StringLength(3)]
        public string CodigoOperacao { get; set; }
    }
}
