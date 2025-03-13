using jogo.Model.Enimes;
using jogo.Model.Heros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo.Model
{
    public class Combate
    {

        public void Luta(Heroi heroi, Monstro monsto)
        {
            int escolha;
            if(heroi is Mago mago)
            {
                List<Feiticos> feiticos = mago.ListarFeiticos();
                Console.WriteLine("Qual feitico deseja atirar");
                mago.ExibirFeiticos();
                int.TryParse(Console.ReadLine(), out escolha);

                int vidaMonstro =  monsto.Vida - feiticos[escolha].dano;
                if (monsto.Vida <= 0)
                {
                    monsto.Vida = vidaMonstro;
                }
                else
                    Console.WriteLine("Monstro perdeu");
                }

        }
    }
}
