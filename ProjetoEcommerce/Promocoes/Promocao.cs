using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Promocoes
{
    public class Promocao
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public TipoDesconto? TipoDesconto { get; set; }
        public decimal ValorDesconto { get; set; }

        public decimal CalcularDesconto(CarrinhoDeCompras carrinhoDeCompras)
        {
            decimal total = 0;

            foreach (var item in carrinhoDeCompras.Itens)
            {
                total += item.Produto.Preco * item.Quantidade;
            }

            return promocao.CalcularDesconto(total);
        }
        public void AplicarDesconto(Promocao promocao)
        {
            foreach (var item in itens)
            {
                if (item.Produto.Id == promocao.IdProduto)
                {
                    item.Preco = promocao.CalcularDesconto(item.Preco); // aqui é necessário passar o valor do produto
                }
            }
        }
    }
}