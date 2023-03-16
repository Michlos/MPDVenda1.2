using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

using MPDVenda.Model.ApplicationUser;

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
