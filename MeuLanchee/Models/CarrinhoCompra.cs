using MeuLanchee.Context;
using Microsoft.EntityFrameworkCore;

namespace MeuLanchee.Models
{
    public class CarrinhoCompra
    {
        private readonly AppDbContext _context;
        public CarrinhoCompra(AppDbContext context)
        {
                _context = context;
        }


        public string CarrinhoCompraId { get; set; }
        public List<CarrinhoCompraItem> CarrinhoCompraItems { get; set; }

        public static CarrinhoCompra GetCarrinho(IServiceProvider services)
        {
            //Define uma Sessão
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            //Obtem um serviço do tipo do nosso contexto
            var context = services.GetService<AppDbContext>();

            //obtem ou gera o Id do carrinho
            string carrinhoId = session.GetString("CarrinhoId")?? Guid.NewGuid().ToString();

            session.SetString("CariinhoId", carrinhoId);

            return new CarrinhoCompra(context)
            {
                CarrinhoCompraId = carrinhoId,
            };
        }

        public void AdicionarAoCarrinho(Lanche lanche)
        {
            var carrinhCompraItem = _context.CarrinhoCompraItens.SingleOrDefault(
                s=> s.Lanche.LancheId == lanche.LancheId &&
                s.CarrinhoCompraId == CarrinhoCompraId);

            if (carrinhCompraItem == null)
            {
                carrinhCompraItem = new CarrinhoCompraItem
                {
                    CarrinhoCompraId = CarrinhoCompraId,
                    Lanche = lanche,
                    Quantidade = 1
                };
                _context.CarrinhoCompraItens.Add(carrinhCompraItem);
            }
            else
            {
                carrinhCompraItem.Quantidade++;
            }
            _context.SaveChanges();
        }


        public int RemoverDoCarrinho(Lanche lanche)
        {
            var carrinhCompraItem = 
                _context.CarrinhoCompraItens.SingleOrDefault(
               s => s.Lanche.LancheId == lanche.LancheId &&
               s.CarrinhoCompraId == CarrinhoCompraId);

            var quantidadeLocal = 0;

            if (carrinhCompraItem != null)
            {
                if (carrinhCompraItem.Quantidade > 1)
                {
                    carrinhCompraItem.Quantidade--;
                    quantidadeLocal = carrinhCompraItem.Quantidade;
                }
                else
                {
                    _context.CarrinhoCompraItens.Remove(carrinhCompraItem);
                }
            }
            _context.SaveChanges();
            return quantidadeLocal;
        }

        public List<CarrinhoCompraItem> GetCarrinhoCompraItens()
        {
            return CarrinhoCompraItems ?? (
                CarrinhoCompraItems = 
                _context.CarrinhoCompraItens
                .Where(c=> c.CarrinhoCompraId == CarrinhoCompraId)
                .Include(s=>s.Lanche)
                .ToList());

        }
        public void LimpaCarrinho()
        {
            var carrinhoItens = _context.CarrinhoCompraItens
                .Where(carrinho => 
                carrinho.CarrinhoCompraId == CarrinhoCompraId);
            _context.CarrinhoCompraItens.RemoveRange(carrinhoItens);
            _context.SaveChanges();
        }

        public decimal GetCarrinhoCompraTotal()
        {
            var total = _context.CarrinhoCompraItens
                .Where(c => c.CarrinhoCompraId == CarrinhoCompraId)
                .Select(c => c.Lanche.Preco * c.Quantidade).Sum();

            return total;
        }

    }
}
