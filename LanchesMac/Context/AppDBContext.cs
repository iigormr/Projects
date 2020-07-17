using LanchesMac.Models;
using Microsoft.EntityFrameworkCore;

namespace LanchesMac.Context
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        public DbSet<Lanche> LCH_LANCHES { get; set; }
        public DbSet<Categoria> LCH_CATEGORIAS { get; set; }
    }
}
