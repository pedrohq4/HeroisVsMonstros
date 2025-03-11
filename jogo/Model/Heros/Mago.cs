﻿using jogo.Model.Enimes;
using System.Reflection.PortableExecutable;

namespace jogo.Model.Heros
{
    class Mago : Heroi
    {
        int Vida;
        int Energia;
        int TamanhoInventario;
        int Mana;
        int PoderMagico;
        int NumeroDeFeitiços;
        List<Feiticos> feiticosAprendidos;
        public Mago(string nome) : base(nome)
        {
            Vida = new Random().Next(20, 50);
            Mana = new Random().Next(50, 100);
            PoderMagico = new Random().Next(1, 20);
            NumeroDeFeitiços = new Random().Next(2, 5);

            List<Feiticos> feiticos = new List<Feiticos>();
            feiticos.Add(new Feiticos("Raios", 10, 5));
            feiticos.Add(new Feiticos("Bola de Fogo", 30, 15));
            feiticos.Add(new Feiticos("Raio de gelo", 15, 10));
            feiticos.Add(new Feiticos("Espinhos", 20, 10));
            feiticos.Add(new Feiticos("Cura", 50, 30));
            feiticosAprendidos = new List<Feiticos>();

            for (int i = 0; i < NumeroDeFeitiços; i++)
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

        public override string ExibirPersonagem()
        {

            string feiticosStr = string.Join("\n", feiticosAprendidos.Select(s => $"Nome: {s.nome}, Dano: {s.dano}, Custo de Mana: {s.custoMana}"));

            return $"Nome: {Nome}, Vida: {Vida}, Mana: {Mana}, Poder Mágico: {PoderMagico}, Número de Feitiços: {NumeroDeFeitiços}," +
                $" Nivel atual: {Nivel}" + $"\nFeitiços Aprendidos:\n{feiticosStr}";
        }

        public bool Atacar(int feticoescolhido, Monstro monstro)
        {
            int acerto = new Random().Next(0, 1);
            
            if (acerto == 1)
            {
              var feitico = feiticosAprendidos[feticoescolhido];

              var danocausado = monstro.Vida - feitico.dano;

             return true;
            }
            else
             return false;
        }
    }
}
