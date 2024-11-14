using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeuLanchee.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }
        
        [Required(ErrorMessage = "O nome do lanche deve ser informado")]
        [Display(Name = "Nome do Lanche")]
        [StringLength(80,MinimumLength =10, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo {2} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A descrição do lanche deve ser informado")]
        [Display(Name = "Descrição do Lanche")]
        [MinLength ( 20, ErrorMessage = "A descrição de ter no mínimo {1} caracteres")]
        [MaxLength ( 200, ErrorMessage = "A descrição pode exceder {1} caracteres")]
        public string DescricaoCurta { get; set; }

        [Required(ErrorMessage = "A descrição detalhda do lanche deve ser informado")]
        [Display(Name = "Descrição Detalhada do Lanche")]
        [MinLength(20, ErrorMessage = "A descrição detalhada de ter no mínimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "A descrição Detalhada pode exceder {1} caracteres")]
        public string DescricaoDetalhada { get; set; }

        [Required(ErrorMessage = "Informe o preço do lanche")]
        [Display(Name = "Preço")]
        [Column(TypeName ="decimal(10,2)")]
        [Range(1,999.99, ErrorMessage ="O preço deve estar entre 1 e 999,99")]
        public decimal Preco { get; set; }

        [Display(Name = "Caminho da Imagem Normla")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo {2} caracteres")]
        public string ImagemUrl { get; set; }

        [Display(Name = "Caminho da Imagem Miniatura")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo {2} caracteres")]
        public string ImagemThumbnailrUrl { get; set; }

        [Display(Name = "Preferido?")]
        public bool IsLanchePreferido { get; set; }

        [Display(Name = "Estoque")]
        public bool EmEstoque { get; set; }

        //Definição do relacionamento entre as classes (Propriedades de navegação)
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
