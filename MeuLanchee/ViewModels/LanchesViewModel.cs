using MeuLanchee.Models;

namespace MeuLanchee.ViewModels
{
    public class LanchesViewModel
    {
        public IEnumerable<Lanche> Lanches { get; set; }
        public string CategoriaAtual { get; set; }
    }
}
