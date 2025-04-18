using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo.Model.Heros.Guerreiro
{
    public sealed class Ataque
    {
        public string Nome;
        public int Dano;
        public int CustoEnergia;

        public Ataque(string nome, int dano, int custoEnergia)
        {
            Nome = nome;
            Dano = dano;
            CustoEnergia = custoEnergia;
        }
    }
}
