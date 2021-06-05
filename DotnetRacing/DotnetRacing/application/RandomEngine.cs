using System;

namespace DotnetRacing.application
{
    public class RandomEngine: IEngine
    {
        private readonly Random _random;

        public RandomEngine(Random random)
        {
            _random = random;
        }

        public int FuelTheCar()
        {
            return _random.Next(0, 10);
        }
    }
}