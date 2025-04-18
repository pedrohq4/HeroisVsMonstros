using jogo.Model.Heros.Mago;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo.Model.Heros.Guerreiro
{
    public class Guerreiro : Heroi
    {
        public int Energia;

        public int Forca;

        public List<Ataque> AtaquesAprendidos;

        public Guerreiro(string nome) : base(nome)
        {
            Vida = new Random().Next(80, 100);
            Energia = new Random().Next(20, 30);
            Forca = new Random().Next(80, 100);
            AtaquesAprendidos = new List<Ataque>();
            GeracaoAtaques();
        }

        private void GeracaoAtaques()
        {
            List<Ataque> ataques = new List<Ataque>
            {
                new Ataque("Ataque Lateral", 10, 5),
                new Ataque("Ataque Frontal", 30, 15),
                new Ataque("Ataque Pesado", 15, 10)
            };

            for (int i = 0; i < 3; i++)
            {
                int num = new Random().Next(0, ataques.Count);
                if (AtaquesAprendidos.Contains(ataques[num]))
                {
                    i--;
                    continue;
                }
                AtaquesAprendidos.Add(ataques[num]);
            }
        }

        public override string ExibirPersonagem()
        {
            return $"Nome: {Nome}, Vida: {Vida}, Força: {Forca},\n Ataques: {ExibirAtaques()}";
        }

        public string ExibirAtaques()
        {
            return string.Join("\n", AtaquesAprendidos.Select(a => $"Nome: {a.Nome}, Dano: {a.Dano}, Custo de Mana: {a.CustoEnergia}"));
        }

        public override int Atacar()
        {
            Console.WriteLine("Qual ataque deseja fazer");
            ExibirAtaques();
            int.TryParse(Console.ReadLine(), out int ataqueEscolhido);
            return AtaquesAprendidos[ataqueEscolhido].Dano;
        }
    
    }
}
