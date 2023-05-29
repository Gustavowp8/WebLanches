using Microsoft.EntityFrameworkCore;
using WebLanches.Models;

namespace WebLanches.Context
{
    public class WebLanchesContext : DbContext
    {
        public WebLanchesContext(DbContextOptions<WebLanchesContext> options) : base(options) 
        {
            
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Lanche> Lanches { get; set;}
        public DbSet<CarrinhoCompraItem> carrinhoCompraItens { get; set; }
    }
}
