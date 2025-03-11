using jogo.PlayerModel;
using System.Reflection.PortableExecutable;

namespace jogo.Heroi
{
    class Mago : Heroi
    {
        int vida;
        int energia;
        int tamanhoInventario;
        int mana;
        int poderMagico;
        int numeroDeFeitiços;
        List<Feiticos> feiticosAprendidos;

        public Mago(string nome) : base(nome)
        {
            this.vida = new Random().Next(20, 50);
            this.mana = new Random().Next(50, 100);
            this.poderMagico = new Random().Next(1, 20);
            this.numeroDeFeitiços = new Random().Next(2, 5);

            List<Feiticos> feiticos = new List<Feiticos>();
            feiticos.Add(new Feiticos("Raios", 10, 5));
            feiticos.Add(new Feiticos("Bola de Fogo", 30, 15));
            feiticos.Add(new Feiticos("Raio de gelo", 15, 10));
            feiticos.Add(new Feiticos("Espinhos", 20, 10));
            feiticos.Add(new Feiticos("Cura", 50, 30));
            feiticosAprendidos = new List<Feiticos>();

            for (int i = 0; i < numeroDeFeitiços; i++)
            {
                int num = new Random().Next(0, 4);
                if(feiticosAprendidos.Contains(feiticos[num]))
                {
                    i--;
                    continue;
                }
                feiticosAprendidos.Add(feiticos[num]);
            }
        }

        public override String ExibirPersonagem()
        {
            string feiticosStr = string.Join(", ", feiticosAprendidos.Select(f => f.nome));
            return $"Nome: {nome}, Vida: {vida}, Mana: {mana}, Poder Mágico: {poderMagico}, Número de Feitiços: {numeroDeFeitiços}" +
                $"\nFeitiços Aprendidos:\n{feiticosStr}";
        }
    }
}
