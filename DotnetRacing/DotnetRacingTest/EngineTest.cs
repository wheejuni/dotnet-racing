using System;
using DotnetRacing.application;
using Xunit;

namespace DotnetRacingTest
{
    public class EngineTest
    {
        [Fact]
        public void TestOfFact()
        {
            Assert.True(true);
        }

        [Fact]
        public void TestOfAlwaysForwardEngine()
        {
            //given
            IEngine engine = new AlwaysForwardEngine();
            
            //when
            var result = engine.FuelTheCar();
            
            //then
            Assert.Equal(1, result);
        }

        [Fact]
        public void TestOfRandomFueledEngine()
        {
            //given
            IEngine engine = new RandomEngine(GenerateTestableRandom());
            
            //when
            var result = engine.FuelTheCar();
            
            //then
            Assert.Equal(1, result);

        }

        private static Random GenerateTestableRandom()
        {
            return new TestableRandom();
        }
    }

    public class TestableRandom : Random
    {
        public override int Next(int minValue, int maxValue)
        {
            return 1;
        }
    } 
}