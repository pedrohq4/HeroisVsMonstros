using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo.Model.Enimes
{
    public abstract class Monstro : Combate
    {
        public int Vida { get; set; }
        public int Dano { get; set; }
    }
}
