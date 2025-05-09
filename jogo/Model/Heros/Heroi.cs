﻿namespace jogo.Model.Heros
{
    public abstract class Heroi : Game
    {
        public string Nome { get; protected set; }
        public int Vida { get; protected set; }
        public int Nivel { get; set; }
        public int Experiencia { get; set; }
        public bool Vivo { get; private set;}

        public Heroi(string nome)
        {
            Nome = nome;
            Nivel = 1;
            Experiencia = 0;
            Vivo = true;
        }

        public abstract string ExibirPersonagem();

        protected int SubirNivel(int nivelUp)
        {
            return Nivel += nivelUp;
        }

        public bool VerificarSeVivo()
        {
            if (Vida <= 0)
                return Vivo = false;

            else return true;
        }
        public abstract int Atacar();
        public void TomarDano(int dano)
        {
            Vida -= dano;
        }

        public void VerificarSeUpNivel()
        {
            if (Experiencia >= 100){
                do
                {
                    Experiencia -= 100;
                    Nivel++;

                } while (Experiencia > 99);
            }
            
        }
    }
}