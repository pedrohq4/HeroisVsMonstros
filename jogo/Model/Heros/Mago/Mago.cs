using jogo.Model.Enimes;
using System.Reflection.PortableExecutable;

namespace jogo.Model.Heros.Mago
{
    public class Mago : Heroi
    {
        int Mana;
        int PoderMagico;
        int NumeroDeFeiticos;
        public List<Feitico> FeiticosAprendidos = new List<Feitico>();
        public Mago(string nome) : base(nome)
        {
            Vida = new Random().Next(20, 50);
            Mana = new Random().Next(50, 100);
            PoderMagico = new Random().Next(1, 5);
            NumeroDeFeiticos = new Random().Next(2, 5);
            GeracaoFeiticos();
        }

        private void GeracaoFeiticos()
        {
            List<Feitico> feiticos = new List<Feitico>
            {
                new Feitico("Raios", 10, 5),
                new Feitico("Bola de Fogo", 30, 15),
                new Feitico("Raio de gelo", 15, 10),
                new Feitico("Espinhos", 20, 10),
                new Feitico("Cura", 50, 30)
            };

            for (int i = 0; i < NumeroDeFeiticos; i++)
            {
                int num = new Random().Next(0, 4);
                if (FeiticosAprendidos.Contains(feiticos[num]))
                {
                    i--;
                    continue;
                }
                FeiticosAprendidos.Add(feiticos[num]);
            }
        }

        public override string ExibirPersonagem()
        {
            return $"Nome: {Nome}, Vida: {Vida}, Mana: {Mana}, Poder Mágico: {PoderMagico}, Número de Feitiços: {NumeroDeFeiticos}," +
                $" Nivel atual: {Nivel}" + $"\nFeitiços Aprendidos:\n{ExibirFeiticos()}";
        }

        public string ExibirFeiticos()
        {
            return string.Join("\n", FeiticosAprendidos.Select(s => $"Nome: {s.Nome}, Dano: {s.Dano}, Custo de Mana: {s.CustoMana}"));
        } 

        public List<Feitico> ListarFeiticos()
        {
            return FeiticosAprendidos;
        }

        public override int Atacar()
        {
            Console.WriteLine("Qual feitico deseja atirar");
            ExibirFeiticos();
            int.TryParse(Console.ReadLine(), out int feiticoEscolhido);
            return FeiticosAprendidos[feiticoEscolhido].Dano;
        }
    }
}
