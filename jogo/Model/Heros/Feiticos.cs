using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo.Model.Heros
{
    class Feiticos
    {
        public string nome;
        public int dano;
        public int custoMana;
        public Feiticos(string nome, int dano, int custoMana)
        {
            this.nome = nome;
            this.dano = dano;
            this.custoMana = custoMana;
        }

    }
}
