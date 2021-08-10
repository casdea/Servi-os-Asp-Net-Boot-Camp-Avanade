using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrdemServicoAspNetMVC.Models;

namespace OrdemServicoAspNetMVC.Models
{
    public class Context : DbContext
    {
        public DbSet<OrdemServico> ordensServicos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ServicoMvc;Integrated Security=true");
        }

        public DbSet<OrdemServicoAspNetMVC.Models.PessoaFisica> PessoaFisica { get; set; }

        public DbSet<OrdemServicoAspNetMVC.Models.PessoaJuridica> PessoaJuridica { get; set; }
    }
}
