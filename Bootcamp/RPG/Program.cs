using static System.Console;
using System;
using RPG.src.Entities;

namespace RPG
{
    class Program{
        static void Main(string[] args){

            Personagem arus = new Personagem("Arus",23,"Guerreiro");
            Mago oponnet = new Mago("Malvadão",50,"Mostro");

            WriteLine(arus.Ataque());
            WriteLine(oponnet.Ataque(1));
            WriteLine(oponnet.Ataque(10));
        }
    }
}