using Microsoft.EntityFrameworkCore;
using WebLanches.Context;
using WebLanches.Models;
using WebLanches.Repositories.Interfaces;

namespace WebLanches.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        private readonly WebLanchesContext _context;
        public LancheRepository(WebLanchesContext context)
        {
           _context = context;
        }

        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c=> c.Categoria);

        public IEnumerable<Lanche> LanchesPrefereidos => _context.Lanches.Where(l=> l.IsLanchePreferido).Include(c => c.Categoria);

        public Lanche GetLancheById(int lancheid)
        {
            return _context.Lanches.FirstOrDefault(l => l.LancheId == lancheid);
        }
    }
}
