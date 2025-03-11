using jogo.Heroi;
using System.ComponentModel.Design;

namespace jogo
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int menu = 1;
            do
            {
                Console.Clear();
                Console.WriteLine("Criador de personagem");
                Console.WriteLine("Escolha o nome do seu personagem: ");
                string nome = Console.ReadLine();

                var mago = new Mago(nome);

                Console.WriteLine(mago.ExibirPersonagem());
                Console.ReadKey();
            } while (menu != 0);
        }
    }
}
