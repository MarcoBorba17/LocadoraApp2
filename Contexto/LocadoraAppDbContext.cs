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
            optionsBuilder.UseMySQL("Server=localhost;Database=locadorapp;User=root;Password=12345;");
        }
    }
}
