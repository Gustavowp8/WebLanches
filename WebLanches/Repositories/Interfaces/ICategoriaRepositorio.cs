using WebLanches.Models;

namespace WebLanches.Repositories.Interfaces
{
    public interface ICategoriaRepositorio
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
