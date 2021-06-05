using System;
using DotnetRacing;
using DotnetRacing.application;
using Xunit;

namespace DotnetRacingTest
{
    public class CarTest
    {
        [Fact]
        public void TestOfCar()
        {
            //given
            var engine = new AlwaysForwardEngine();

            var car = new Car(engine) {Position = 3};

            //when
            var result = car.Position;
            
            //then
            Assert.Equal(3, result);
        }

        [Fact]
        public void TestOfEnginePoweredCars()
        {
            //given
            var engine = new AlwaysForwardEngine();
            var car = new Car(engine) {Position = 0};
            
            //when
            car.MoveForward();
            var result = car.Position;
            
            //then
            Assert.Equal(1, result);
        }

        [Fact]
        public void TestOfCarPositionRepresentation()
        {
            //given
            var player = new Player() {Name = "호눅스"};
            var car = new Car(new AlwaysForwardEngine(), player);

            for (var i = 0; i < 3; i++)
            {
                car.MoveForward();
            }
            
            //when
            var result = car.RepresentPositionInString();
            
            //then
            Assert.Equal("호눅스: ---", result);
        }
        
        [Fact]
        public void TestOfPlayerName()
        {
            //given
            var player = new Player {Name = "호눅스"};
            
            //when
            var result = player.Name;
            
            //then
            Assert.Equal("호눅스", result);
        }
    }
}