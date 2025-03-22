using jogo.Model.Enimes;
using jogo.Model.Heros;
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
            if (heroi is Mago mago)
            {
                do
                {
                    Console.WriteLine("Turno do jogador");
                    Console.WriteLine("Qual feitico deseja atirar");
                    mago.ExibirFeiticos();
                    int.TryParse(Console.ReadLine(), out int feiticoEscolhido);

                    monstro.TomarDano(mago.feiticosAprendidos[feiticoEscolhido].dano);

                    if (!monstro.VerificarSeVivo())
                    {
                        Console.WriteLine("Monstro perdeu");
                        break;
                    }

                    Console.WriteLine("Turno do monstro");
                    heroi.TomarDano(monstro.Dano);
                    if (!heroi.VerificarSeVivo())
                        Console.WriteLine("Heroi perdeu");


                } while (mago.Vivo || monstro.Vivo);
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
            for (int i = 0; i < 10; i++)
            {
                Horda.Add(new Esqueleto());
            }
        }
    } 
}
