using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo.Model.Enimes
{
    public class Monstro : Combate
    {
        public int Vida { get; private set; }
        public int Dano { get; set; }

        public Monstro CriarMonstro(int Tipomonstro)
        {
            switch (Tipomonstro) {
                case 1:
                    Random rand = new Random();
                    Esqueleto esqueleto = new Esqueleto();
                    esqueleto.Vida = rand.Next(10,20);
                    esqueleto.Dano = rand.Next(20, 30);

                    return esqueleto;
                default:
                    return new Esqueleto();
            }
        }
    }
}
