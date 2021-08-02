using System;
using ConsoleApp;
using Game.Lib;
using Game.Interface;


namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogador jogador1 = new Player("Ives Costa");
            Jogador jogador2 = new Jogador2();
            var game = new Game.Lib.Game.Game(jogador2);
            game.StartGame();
            var game2 = new Game.Lib.Game.Game(jogador1);
            game2.StartGame();
        }
    }

   
}

