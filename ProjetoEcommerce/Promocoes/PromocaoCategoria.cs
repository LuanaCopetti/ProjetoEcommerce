using ProjetoEcommerce.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Promocoes
{
    public class PromocaoCategoria
    {
        private CategoriaProduto acessorio;
        private int v;

        public PromocaoCategoria(CategoriaProduto acessorio, int v)
        {
            this.acessorio = acessorio;
            this.v = v;
        }

        public int Id { get; set; }
        public CategoriaProduto Categoria { get; set; }
        public int PromocaoId { get; set; }
        public virtual Promocao Promocao { get; set; }
    }
}
