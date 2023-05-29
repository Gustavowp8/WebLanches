using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebLanches.Models
{
    [Table("CarrinhoCompraItens")]
    public class CarrinhoCompraItem
    {
        //Chave primaria
        public int CarrinhoCompraItemId { get; set; }

        //Propriedade do tipo lanche para mapear uma chave estrangeira
        public Lanche Lanche { get; set; }

        //Representa a quantidade de lanche
        public int Quantidade { get; set; }

        //Representa a classe do id do carrinho
        [StringLength(200)]
        public string CarrinhoCompraId { get; set; }
    }
}
