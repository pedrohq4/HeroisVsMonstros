using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo.Model.Enimes
{
    public class Monstro : Game
    {
        Random rand = new Random();
        public int Vida { get; private set; }
        public int Dano { get; set; }
        public bool Vivo { get; private set; }

        public Monstro()
        {
            Vida = rand.Next(10,20);
            Dano = rand.Next(20, 30);
            Vivo = true;

        }

        public void TomarDano(int dano)
        {
            Vida -= dano;
        }

        public bool VerificarSeVivo()
        {
            if (Vida <= 0)
                return Vivo = false;

            else return true;
        }
    }
}
