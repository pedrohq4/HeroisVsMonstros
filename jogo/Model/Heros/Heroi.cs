namespace jogo.Model.Heros
{
    public abstract class Heroi : Combate
    {
        public string Nome { get; protected set; }
        public int Nivel { get; private set; } = 1;
        public double Experiencia { get; private set; } = 0;

        public Heroi(string nome)
        {
            Nome = nome;
        }

        public abstract string ExibirPersonagem();

        protected int SubirNivel(int nivelUp)
        {
            return Nivel += nivelUp;
        }

        public Heroi CriarPersonagem()
        {
            Console.WriteLine("Criador de personagem");
            Console.WriteLine("Escolha o nome do seu personagem: ");

            string nome = Console.ReadLine();
            var mago = new Mago(nome);

            return mago;
        }
    }
}