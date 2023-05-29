using Microsoft.AspNetCore.Mvc;
using WebLanches.Repositories.Interfaces;
using WebLanches.ViewsModels;

namespace WebLanches.Controllers
{
    public class LancheController : Controller
    {
        //Referencia ao repositorio
        private readonly ILancheRepository _lancheRepository;

        //Construtor do repositorio
        public LancheController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        //View para exibir uma lista.
        public IActionResult List()
        {
            ViewData["Titulo"] = "Todos os lanches";
            ViewData["Data"] = DateTime.Now;
            /*
            var lanches = _lancheRepository.Lanches;
            return View(lanches);*/

            var lancheListViewModel = new LancheListViewModel();
            lancheListViewModel.Lanches = _lancheRepository.Lanches;
            lancheListViewModel.CategoriaAtual = "Categoria atual";

            return View(lancheListViewModel);
        }
    }
}
