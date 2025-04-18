using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo.Model.Enimes
{
    public class Esqueleto : Monstro
    {
        public Esqueleto()
        {
            Nome = "Esqueleto";
            ExpericenciaDropada = new Random().Next(50, 100);
            Vida = new Random().Next(10, 20);
            Dano = new Random().Next(5, 10);
        }

    }


}
