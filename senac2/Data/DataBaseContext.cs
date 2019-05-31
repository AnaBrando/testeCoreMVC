using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using senac2.Models;

    public class DataBaseContext : DbContext
    {
        public DataBaseContext (DbContextOptions<DataBaseContext> options)
            : base(options)
        {
        }

        public DbSet<senac2.Models.Marca> Marca { get; set; }

        public DbSet<senac2.Models.TipoProduto> TipoProduto { get; set; }

        public DbSet<senac2.Models.Produto> Produto { get; set; }
    
}
