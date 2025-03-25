using jogo.Model;
using jogo.Model.Enimes;
using jogo.Model.Heros;
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
            int menu = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Menu");
                int.TryParse(Console.ReadLine(), out menu);
                switch (menu)
                {
                    case 1:
                        Heroi player = game.CriarPersonagem();
                        game.CriarHorda();
                        Console.WriteLine(player.ExibirPersonagem());

                        foreach(Monstro monstro in game.Horda)
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
