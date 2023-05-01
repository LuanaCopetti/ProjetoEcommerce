using ProjetoEcommerce.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Models
{
        public class Produto
        {
            public int Id { get; set; }
            public string? Nome { get; set; }
            public decimal Preco { get; set; }
            public string? Descricao { get; set; }
            public CategoriaProduto Categoria { get; set; }
        }
    }

