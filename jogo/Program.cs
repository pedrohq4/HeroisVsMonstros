using jogo.Model;
using jogo.Model.Enimes;
using jogo.Model.Heros;
using System.Collections.Generic;
using System.ComponentModel.Design;

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

                        for (int i = 0; i <= game.Horda.Count; i++)
                             game.Combate(player, game.Horda[i]);

                      break;
                }
            } while (menu != 0);
        }
    }
}
