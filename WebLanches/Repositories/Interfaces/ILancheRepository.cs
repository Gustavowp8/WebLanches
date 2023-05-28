using WebLanches.Models;

namespace WebLanches.Repositories.Interfaces
{
    public interface ILancheRepository
    {
        IEnumerable<Lanche> Lanches { get; } //Retorna uma lista

        IEnumerable<Lanche> LanchesPrefereidos { get;} //obter dados pelo ID

        Lanche GetLancheById(int lancheid);
    }
}
