using ProjetoEcommerce.Enums;
using ProjetoEcommerce.Models;
using ProjetoEcommerce.Promocoes;
using System;

namespace ProjetoEcommerce
{
    class Program
    {
        private static CarrinhoDeCompras CarrinhoDeCompras;

        static void Main(string[] args)
        {
            // Criação de uma instância do carrinho de compras
            CarrinhoDeCompras = new CarrinhoDeCompras();

            // Criação de alguns produtos
            Camiseta camiseta1 = new Camiseta("Camiseta Listrada", 49.99, "P", "Branco e Preto");
            Calca calca1 = new Calca("Calça Jeans", 99.99, "40", "Azul");
            Sapato sapato1 = new Sapato("Sapato Social", 199.99, "42", "Preto");

            // Adição dos produtos ao carrinho de compras
            carrinho.AdicionarProduto(camiseta1);
            carrinho.AdicionarProduto(calca1);
            carrinho.AdicionarProduto(sapato1);

            // Criação de uma promoção para produtos da categoria Acessorio com 10% de desconto
            PromocaoCategoria promocaoAcessorios = new PromocaoCategoria(CategoriaProduto.Acessorio, 10);

            // Adição da promoção ao carrinho de compras
            carrinho.AdicionarPromocao(promocaoAcessorios);

            // Impressão do valor total dos produtos no carrinho de compras
            Console.WriteLine("Valor total dos produtos no carrinho: R$ " + carrinho.CalcularValorProdutos());

            // Impressão do valor total dos produtos com desconto
            Console.WriteLine("Valor total com desconto: R$ " + carrinho.CalcularValorDescontos());

            // Realização do pagamento
            Console.WriteLine(carrinho.RealizarPagamento("João da Silva", "123.456.789-00", "1111 2222 3333 4444", "12/23", "123"));
        }
    }
}
