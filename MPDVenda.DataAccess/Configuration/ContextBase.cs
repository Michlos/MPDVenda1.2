using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

using MPDVenda.Model.ApplicationUser;
using MPDVenda.Model.Enums.Endereco;
using MPDVenda.Model.Enums.Filial;
using MPDVenda.Model.Enums.Financeiro;
using MPDVenda.Model.Enums.ItemVenda;
using MPDVenda.Model.Enums.ParceiroNegocio;
using MPDVenda.Model.Estoque;
using MPDVenda.Model.Filial;
using MPDVenda.Model.Financeiro;
using MPDVenda.Model.ParceiroNegocio;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPDVenda.DataAccess.Configuration
{
    public class ContextBase : IdentityDbContext<ApplicationUser>
    {
        public ContextBase(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Parceiro> Parceiro { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Banco> Banco { get; set; }
        public DbSet<Caixa> Caixa { get; set; }
        public DbSet<MovimentoCaixa> MovimentoCaixa { get; set; }
        public DbSet<Filial> Filial { get; set; }
        public DbSet<ItemVenda> ItemVenda { get; set; }
        public DbSet<TipoParceiro> TipoParceiro { get; set; }
        public DbSet<TipoPessoa> TipoPessoa { get; set; }
        public DbSet<TipoCompraItem> TipoCompraItem { get; set; }
        public DbSet<TipoItem> TipoItem { get; set; }
        public DbSet<TipoMovimentacaoEstoque> TipoMovimentacaoEstoque { get; set; }
        public DbSet<PartidaDobrada> PartidaDobrada { get; set; }
        public DbSet<RegimeTributario> RegimeTributario { get; set; }
        public DbSet<Bairro> Bairro { get; set; }
        public DbSet<Cidade> Cidade { get; set; }
        public DbSet<TipoEndereco> TipoEndereco { get; set; }
        public DbSet<TipoLogradouro> TipoLogradouro { get; set; }
        public DbSet<UnidadeFederacao> unidadeFederacao { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }






        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ApplicationUser>().ToTable("AspNetUsers").HasKey(t => t.Id);
            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetConnectionString());
            base.OnConfiguring(optionsBuilder);
            }
        }

        private string GetConnectionString()
        {
            return "Data Source=MPDVENDA;Initial Catalog=MPDVENDA;Integrated Security=True";
            //return "Data Source=SQLSISTEMAFINANCEIRO;Initial Catalog=FINANCEIRO_2023;Integrated Security=Tue;User ID=sa;Password=S$f1@154alfa; ";
        }
    }
    
}
