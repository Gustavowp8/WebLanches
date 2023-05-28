using WebLanches.Context;
using WebLanches.Models;
using WebLanches.Repositories.Interfaces;

namespace WebLanches.Repositories
{
    public class CategoriaRepository : ICategoriaRepositorio
    {
        private readonly WebLanchesContext _context;

        public CategoriaRepository(WebLanchesContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
