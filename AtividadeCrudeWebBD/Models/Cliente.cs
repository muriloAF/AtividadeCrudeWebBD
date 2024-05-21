using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeCrudeWebBD.Models
{
    public class Cliente : Base
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Tefelone { get; set; }
        public DateTime DataDeCombra { get; set; }
        public  Produto Produto { get; set; }   


        
    }
}
