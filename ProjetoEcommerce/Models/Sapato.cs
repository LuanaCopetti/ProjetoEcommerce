using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEcommerce.Models
{
    public class Sapato : Acessorio
    {
        public Sapato(string v1, double v2, string v3, string v4)
        {
            V1 = v1;
            V2 = v2;
            V3 = v3;
            V4 = v4;
        }

        public string Tamanho { get; set; }
        public string Cor { get; set; }
        public string V1 { get; }
        public double V2 { get; }
        public string V3 { get; }
        public string V4 { get; }
    }
}
