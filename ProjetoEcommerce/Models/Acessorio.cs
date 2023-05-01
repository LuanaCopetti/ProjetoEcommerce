using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Models
{
    public abstract class Acessorio : Produto
    {
        public string Tamanho { get; set; }
    }
}
