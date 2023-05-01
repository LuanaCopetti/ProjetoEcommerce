using ProjetoEcommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.CarrinhoDeCompras
{
    public class ItemCarrinho
    {
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }

        public ItemCarrinho(Produto produto, int quantidade)
        {
            Produto = produto;
            Quantidade = quantidade;
        }

        public decimal CalcularSubtotal()
        {
            return Produto.Preco * Quantidade;
        }
    }
}
