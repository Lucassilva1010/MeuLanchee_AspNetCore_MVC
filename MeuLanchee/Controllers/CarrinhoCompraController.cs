using MeuLanchee.Models;
using MeuLanchee.Repositories.Interfaces;
using MeuLanchee.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MeuLanchee.Controllers
{
    public class CarrinhoCompraController : Controller
    {
        //Variavel somente leitura
        private readonly ILanchesRepository _lancheRepository;
        private readonly CarrinhoCompra _carrinhoCompra;

        public CarrinhoCompraController(ILanchesRepository lanchesRepository, CarrinhoCompra carrinhoCompra)
        {
            _lancheRepository = lanchesRepository;
            _carrinhoCompra = carrinhoCompra;

        }
        public IActionResult Index()
        {
            var itens = _carrinhoCompra.GetCarrinhoCompraItens();

            _carrinhoCompra.CarrinhoCompraItems = itens;
            var carrinhoCompraVM = new CarrinhoCompraViewModel
            {
                CarrinhoCompra = _carrinhoCompra,
                CarrinhoCompraTotal = _carrinhoCompra.GetCarrinhoCompraTotal(),
            };

            return View(carrinhoCompraVM);
        }

        public RedirectToActionResult AdicionarItemNoCarrinhoCompra( int lancheId)
        {
            var lanchesSelecionado = _lancheRepository.Lanches.FirstOrDefault(p => p.LancheId == lancheId);
            if (lanchesSelecionado != null)
            {
                _carrinhoCompra.AdicionarAoCarrinho(lanchesSelecionado);
            }
            return RedirectToAction("Index");
        }

        public IActionResult RemoverItemDoCarrinhoCompra(int lancheId)
        {
            var lancheSelecionado = _lancheRepository.Lanches.FirstOrDefault(p=>p.LancheId == lancheId);

            if (lancheSelecionado!= null)
            {
                _carrinhoCompra.RemoverDoCarrinho(lancheSelecionado);
            }

            return RedirectToAction("Index");
        }




    }
}
