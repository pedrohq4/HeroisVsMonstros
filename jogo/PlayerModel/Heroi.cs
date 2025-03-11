namespace jogo.Heroi
{
    public abstract class Heroi
    {
        public string nome;
        int nivel = 1;
        int experiencia = 0;

        public Heroi(string nome)
        {
            this.nome = nome;
        }

        public abstract String ExibirPersonagem();
    }
}
