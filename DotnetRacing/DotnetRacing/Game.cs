using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using DotnetRacing.application;
using DotnetRacing.presentation;

namespace DotnetRacing
{
    public class Game
    {
        private readonly IEngine _certifiedEngine;
        private List<Car> Participants { get; set; }
        
        public Game(IEngine certifiedEngine)
        {
            _certifiedEngine = certifiedEngine;
        }

        public void Initialize()
        {
            var inputView = new PlayerNameInput();
            Console.WriteLine("참가자 카운트를 입력해 주십시오.");
            
            inputView.Initialize(int.Parse(Console.In.ReadLine() ?? string.Empty));
            inputView.GetNameInput();
            Participants = inputView
                .GetAsPlayer()
                .Select(player => new Car(_certifiedEngine, player))
                .ToList();
            
            Console.WriteLine("게임 시작 준비가 끝남");
        }

        public void MoveCarForward()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(100);
                
                Console.WriteLine($"제 {i}라운드");
                Participants.ForEach(x =>
                {
                    x.MoveForward();
                    Console.WriteLine(x.RepresentPositionInString());
                });
            }
        }

        public void PrintWinner()
        {
            Participants.Sort((x, y) => y.Position - x.Position);
            
            Console.WriteLine("참가자 점수판");
            Participants.ForEach(x =>
            {
                Console.WriteLine($"{x.GetPlayerName()}: {x.Position}점");
            });

            var winner = Participants[0];
            Console.WriteLine($"우승자 {winner.GetPlayerName()} 축하합니다. 그의 점수: {winner.Position}");
            
        }
    }
}