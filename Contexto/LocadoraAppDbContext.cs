using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocadoraApp2.Classes;
using Microsoft.EntityFrameworkCore;

namespace LocadoraApp2.Contexto
{
    internal class LocadoraAppDbContext : DbContext
    {
        public DbSet<Midia> Midias { get; set; }
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            string conexao = "Server=localhost;Database=locadorapp;User=root;Password=12345;port=3306; charset=utf8mb4;";

            optionsBuilder.UseMySql(conexao,
                ServerVersion.AutoDetect(conexao));
    
        }
    }
}
