using jogo.Model;
using jogo.Model.Enimes;
using jogo.Model.Heros;
using jogo.Model.Heros.Guerreiro;
using jogo.Model.Heros.Mago;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Numerics;

namespace jogo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            List<Heroi> personagens = new List<Heroi>();
            int menu = 0;
            Heroi player;
            do
            {
                Console.WriteLine("Menu\n1.Criar personagem\n2.lutar");
                int.TryParse(Console.ReadLine(), out menu);
                switch (menu)
                {
                    case 1:
                        player = game.CriarPersonagem();
                        Console.WriteLine(player.ExibirPersonagem());
                        personagens.Add(player);

                      break;

                    case 2:
                        Console.WriteLine("Qual personagem deseja jogar");
                        Console.WriteLine("-----------------------------------");
                        for(int i = 0; i < personagens.Count; i++)
                        {
                            string classe = "";

                            if (personagens[i] is Mago)
                            {
                                classe = "mago";
                            }
                            else if (personagens[i] is Guerreiro)
                            {
                                classe = "guerreiro";
                            }

                            Console.WriteLine($"{i}. {personagens[i].Nome} - Nivel: {personagens[i].Nivel} Classe: {classe}");
                        }
                        Console.WriteLine("-----------------------------------");
                        int.TryParse(Console.ReadLine(), out int escolha);
                        player = personagens[escolha];

                        foreach (Monstro monstro in game.Horda)
                        {
                            game.Combate(player, monstro);

                            if (!player.Vivo)
                                break;
                        }
                        break;
                }
            } while (menu != 0);
        }
    }
}
