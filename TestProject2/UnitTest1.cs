using jogo.Model;
using jogo.Model.Enimes;
using jogo.Model.Heros;

namespace TestProject2
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Mago mago = new Mago("Pedro");
            Monstro monstro = new Monstro();
            monstro.CriarMonstro(1);

            Combate combate = new Combate();

            combate.Luta(mago, monstro);
        }
    }
}
