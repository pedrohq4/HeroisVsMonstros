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

        public string Nome { get; protected set; }
        public int Vida { get; protected set; }
        public int Dano { get; protected set; }
        public bool Vivo { get; private set; }
        public int ExpericenciaDropada { get; protected set; }

        public Monstro()
        {
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

        public int DroparExpericiencia()
        {
            return ExpericenciaDropada;
        }
    }
}
