using System;
using DotnetRacing.application;

namespace DotnetRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("자동차경주 게임 시으작");

            var game = new Game(new RandomEngine(new Random()));
            
            game.Initialize();
            game.MoveCarForward();
            game.PrintWinner();
        }
    }
}