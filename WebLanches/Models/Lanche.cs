using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebLanches.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }

        [Required(ErrorMessage = "Informe o nome do lanche")]
        [Display(Name = "Nome do lanche")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "O nome deve conter 10 caracteres e menos de 80")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe a descrição do lanche")]
        [Display(Name = "Descrição curta")]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "O nome deve conter 10 caracteres e menos de 100")]
        public string DescricaoCurta { get; set; }

        [Required(ErrorMessage = "Informe a descrição detalhada")]
        [Display(Name = "Descrição detalhada")]
        [StringLength(400, MinimumLength = 10, ErrorMessage = "O nome deve conter 10 caracteres e menos de 400")]
        public string DescricaoDetalhada { get; set; }

        [Required(ErrorMessage = "Informe o preço")]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1,999.99, ErrorMessage = "Preço invalido")]
        public decimal Preco { get; set; }

        [Display(Name = "Caminho imagem normal")]
        [StringLength(200, ErrorMessage = "O caminho deve ter ate 200 dados")]
        public string ImagemUrl { get; set; }

        [Display(Name = "Caminho imagem normal")]
        [StringLength(200, ErrorMessage = "O caminho deve ter ate 200 dados")]
        public string ImagemThumbnailUrl { get; set; }

        [Display(Name = "Preferido?")]
        public bool IsLanchePreferido { get; set; }

        [Display(Name = "Estoque")]
        public bool EmEstoque { get; set; }

        //Relacionamento

        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
