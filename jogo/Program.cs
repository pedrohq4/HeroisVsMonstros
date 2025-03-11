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
            List<Heroi> herois = new List<Heroi>();
            int menu = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Menu");
                int.TryParse(Console.ReadLine(), out menu);
                switch (menu)
                {
                    case 1:
                        Mago mago = CriarPersonagem(herois);
                        herois.Add(mago);
                        break;
                    case 2:
                        Console.WriteLine(herois[0].ExibirPersonagem());
                        Console.ReadKey();
                        break;
                }
            } while (menu != 0);

            static Mago CriarPersonagem(List<Heroi> herois)
            {
               Console.WriteLine("Criador de personagem");
               Console.WriteLine("Escolha o nome do seu personagem: ");
               
               string nome = Console.ReadLine();
               var mago = new Mago(nome);
               herois.Add(mago);

               return mago;
            }
        }
    }
}
