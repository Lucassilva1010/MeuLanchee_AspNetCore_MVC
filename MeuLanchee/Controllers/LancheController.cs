using MeuLanchee.Repositories.Interfaces;
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
            var lanches = _lanchesRepository.Lanches;
            return View(lanches);
        }
    }
}
