using ProjetoEcommerce.Models;
using ProjetoEcommerce.Promocoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.CarrinhoDeCompras
{
    public class CarrinhoDeCompras
    {
        public List<ItemCarrinho> Itens { get; } = new List<ItemCarrinho>();
        public List<Promocao> Promocoes { get; } = new List<Promocao>();

        public void AdicionarItem(Produto produto, int quantidade)
        {
            var itemExistente = Itens.FirstOrDefault(i => i.Produto.Equals(produto));

            if (itemExistente != null)
            {
                itemExistente.Quantidade += quantidade;
            }
            else
            {
                Itens.Add(new ItemCarrinho(produto, quantidade));
            }
        }

        public void AplicarPromocao(Promocao promocao)
        {
            Promocoes.Add(promocao);
        }

        public decimal CalcularValorTotal()
        {
            decimal valorTotal = 0;

            foreach (var item in Itens)
            {
                valorTotal += item.CalcularSubtotal();
            }

            foreach (var promocao in Promocoes)
            {
                valorTotal -= promocao.CalcularDesconto(this);
            }

            return valorTotal;
        }
    }
}
