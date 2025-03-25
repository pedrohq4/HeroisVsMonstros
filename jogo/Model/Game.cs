using jogo.Model.Enimes;
using jogo.Model.Heros;
using jogo.Model.Heros.Mago;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo.Model
{
    public class Game
    {
        public List<Monstro> Horda = new List<Monstro>();

        public void Combate(Heroi heroi, Monstro monstro)
        {
            do
            {
                Console.WriteLine("Turno do jogador");
                TurnoJogador(heroi, monstro);

                if (monstro.Vivo)
                {
                    Console.WriteLine("Turno do monstro");
                    TurnoMonstro(heroi, monstro);
                }
            } while (heroi.Vivo && monstro.Vivo);
        }

        private static void TurnoMonstro(Heroi heroi, Monstro monstro)
        {
            heroi.TomarDano(monstro.Dano);
            if (!heroi.VerificarSeVivo())
                Console.WriteLine("Heroi perdeu");
        }

        private static void TurnoJogador(Heroi heroi, Monstro monstro)
        {
            int danoJogador = 0;
            if (heroi is Mago mago)
            danoJogador = mago.Atacar();
            monstro.TomarDano(danoJogador);
            Console.WriteLine($"O jogador deu {danoJogador} de dano em {monstro.Nome} - {monstro.Vida}");
            Console.ReadKey();

            if (!monstro.VerificarSeVivo())
            {
                Console.WriteLine("Monstro perdeu");
            }
        }

        public Heroi CriarPersonagem()
        {
            Console.WriteLine("Criador de personagem");
            Console.WriteLine("Escolha o nome do seu personagem: ");
            string nome = Console.ReadLine();

            var mago = new Mago(nome);

            return mago;
        }

        public void CriarHorda()
        {
            //for (int i = 0; i < 10; i++)
            //{
            //    Horda.Add(new Esqueleto());
            //}
            Horda.Add(new Esqueleto());
        }
    } 
}
