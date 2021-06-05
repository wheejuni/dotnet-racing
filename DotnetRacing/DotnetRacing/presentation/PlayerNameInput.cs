using System;
using System.Collections.Generic;
using System.Linq;

namespace DotnetRacing.presentation
{
    public class PlayerNameInput
    {
        private List<string> Names { get; set; }

        public void Initialize(int count)
        {
            if (count < 0)
            {
                Console.WriteLine("유효한 카운트가 아닙니다.");
            }

            Names = new List<string>(count);
        }

        public void GetNameInput()
        {
            if (Names == null)
            {
                Console.WriteLine("우선 입력기를 초기화해야 합니다.");
                return;
            }
            
            Console.WriteLine("참가자 이름 입력을 시작한다.");

            for (var i = 0; i < Names.Capacity; i++)
            {
                Console.WriteLine($"{i + 1}번째 참가자의 이름을 입력한다.");
                Names.Add(Console.In.ReadLine());
            }
        }

        public List<Player> GetAsPlayer()
        {
            return Names.Select(name => new Player() {Name = name}).ToList();
        }
    }
}