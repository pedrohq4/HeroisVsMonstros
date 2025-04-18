using jogo.Model.Enimes;
using jogo.Model.Heros;
using jogo.Model.Heros.Guerreiro;
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
            {
                danoJogador = mago.Atacar();
                monstro.TomarDano(danoJogador);
                Console.WriteLine($"O jogador deu {danoJogador} de dano em {monstro.Nome} - {monstro.Vida}");
            }

            else if (heroi is Guerreiro guerreiro)
            {
                danoJogador = guerreiro.Atacar();
                monstro.TomarDano(danoJogador);
                Console.WriteLine($"O jogador deu {danoJogador} de dano em {monstro.Nome} - {monstro.Vida}");
            }

            if (!monstro.VerificarSeVivo())
            {
                Console.WriteLine("Monstro perdeu");
            }
        }

        public Heroi CriarPersonagem()
        {
            Heroi heroi = null;
            Console.WriteLine("Criador de personagem");
            Console.WriteLine("Escolha o nome do seu personagem: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Escolha a classe do seu personagem:\n1.Mago\n2.Guerreiro");
            int.TryParse(Console.ReadLine(), out int classe);

            switch (classe)
            {
                case 1:
                    heroi = new Mago(nome);
                    break;
                case 2:
                    heroi = new Guerreiro(nome);
                    break;
            }

            return heroi;
        }

        public void CriarHorda()
        {
            for (int i = 0; i < 10; i++)
            {
                Horda.Add(new Esqueleto());
            }
        }
    } 
}
