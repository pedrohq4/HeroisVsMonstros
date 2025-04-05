using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo.Model.Heros
{
    public class Guerreiro : Heroi
    {

        public Guerreiro(string nome) : base(nome)
        {
            Vida = new Random().Next(80, 100);
        }

        public override string ExibirPersonagem()
        {
            return $"Nome: {Nome}, Vida: {Vida}";
        }

        public override int Atacar()
        {
            throw new NotImplementedException();
        }
    
    }
}
