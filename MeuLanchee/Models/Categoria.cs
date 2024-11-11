namespace MeuLanchee.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string CategoriaNome { get; set; }

        public string Descricao { get; set; }

        //Definição do relacionamento muito para Muitos
        public List<Lanche> Lanches { get; set; }

    }
}
