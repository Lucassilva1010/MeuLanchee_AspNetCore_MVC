using MeuLanchee.Repositories.Interfaces;
using MeuLanchee.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MeuLanchee.Controllers
{
    public class LancheController : Controller
    {

        private readonly ILanchesRepository _lanchesRepository;

        public LancheController(ILanchesRepository lanches)
        {
            _lanchesRepository = lanches;
        }

        public IActionResult List()
        {
            //var lanches = _lanchesRepository.Lanches;
            //return View(lanches);

            var lanchesListVewModel = new LanchesViewModel();
            lanchesListVewModel.Lanches = _lanchesRepository.Lanches;
            lanchesListVewModel.CategoriaAtual = "Categora Atual";

            return View(lanchesListVewModel);
        }
    }
}
