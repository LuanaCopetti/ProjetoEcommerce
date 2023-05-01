using ProjetoEcommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Promocoes
{
    public class PromocaoProduto
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int PromocaoId { get; set; }
        public virtual Produto Produto { get; set; }
        public virtual Promocao Promocao { get; set; }
    }
}
