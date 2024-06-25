using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using myfinance_web_netcore.Domain;

namespace myfinance_web_netcore.Infrastructure
{
    public class  MyFinanceDbContext : DbContext 
    {
        public DbSet<PlanoConta> PlanoConta { get; set;}
        public DbSet<Transacao> Transacao { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = @"Server=BETA\SQLEXPRESS;Database=myFinance;Trusted_Connection=true;TrustServerCertificate=true";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}

