﻿namespace jogo.Model.Heros
{
    public abstract class Heroi
    {
        public string Nome { get; protected set; }
        public int Nivel { get; private set; } = 1;
        public double Experiencia { get; private set; } = 0;

        public Heroi(string nome)
        {
            Nome = nome;
        }

        public abstract string ExibirPersonagem();
    }
}
