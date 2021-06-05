using System.Collections.Generic;
using System.Linq;
using DotnetRacing.application;

namespace DotnetRacing
{
    public class Car
    {
        private readonly IEngine _engine;
        private readonly Player _player;
        public int Position { get; set; }
        
        public Car(IEngine engine)
        {
            _player = new Player() {Name = "default player 1"};
            _engine = engine;
            Position = 0;
        }

        public Car(IEngine engine, Player player)
        {
            _engine = engine;
            _player = player;
            Position = 0;
        }

        public void MoveForward()
        {
            Position += _engine.FuelTheCar();
        }

        public string RepresentPositionInString()
        {
            var positionRepresentation = "";

            for (var i = 0; i < Position; i++)
            {
                positionRepresentation += "-";
            }
            
            
            return $"{_player.Name}: {positionRepresentation}";
        }

        public string GetPlayerName()
        {
            return _player.Name;
        }
    }
}