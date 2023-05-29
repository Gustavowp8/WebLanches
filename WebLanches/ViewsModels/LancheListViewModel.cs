using WebLanches.Models;

namespace WebLanches.ViewsModels
{
    public class LancheListViewModel
    {
        //Referencia a classe de lanche
        public IEnumerable<Lanche> Lanches { get; set; }

        //Referencia a classe de categoria
        public string CategoriaAtual { get; set; }
    }
}
