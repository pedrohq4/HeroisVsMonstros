using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo.Model.Heros.Mago
{
    public sealed class  Feitico
    {
        public string Nome;
        public int Dano;
        public int CustoMana;
        public Feitico(string nome, int dano, int custoMana)
        {
            Nome = nome;
            Dano = dano;
            CustoMana = custoMana;
        }

    }
}
