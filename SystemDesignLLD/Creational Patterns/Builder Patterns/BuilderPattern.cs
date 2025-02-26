using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemDesignLLD.BehaviouralPatterns.State_Pattern;

namespace SystemDesignLLD.Creational_Patterns.Builder_Patterns
{
    public class BuilderPattern
    {
        public void MainMethod()
        {
            var builder = new CarBuilder();
            var car = builder.SetEngine("v4").SetSeats(6).AddGPS(false).Build();
            Console.WriteLine(car);


            var director = new CarDirector();
            var sportsCar = director.ConstructSportsCar(builder);
            Console.WriteLine(sportsCar);

        }
    }

    public class Car
    { 
        public string Engine { get; set; }  
        public int Seats { get; set; }  
        public bool HasGPS { get; set; }

        public override string ToString()
        {
            return $"Car with engine {Engine} , {Seats} seats, GPS {HasGPS}";
        }

    }
    public interface ICarBuilder
    {
        ICarBuilder SetEngine(string engine);
        ICarBuilder SetSeats(int seats);
        ICarBuilder AddGPS(bool hasGPS);
        Car Build();
    }

    public class CarBuilder : ICarBuilder
    {
        Car car = new Car();
        public ICarBuilder AddGPS(bool hasGPS)
        {
            car.HasGPS = hasGPS;
            return this;
        }

        public Car Build()
        {
            return car;
        }

        public ICarBuilder SetEngine(string engine)
        {
            car.Engine = engine;
            return this;
        }

        public ICarBuilder SetSeats(int seats)
        {
            car.Seats = seats;
            return this;
        }
    }

    // Director (optional)
    public class CarDirector
    {
        public Car ConstructSportsCar(ICarBuilder builder)
        {
            return builder.SetEngine("V8")
                          .SetSeats(2)
                          .AddGPS(true)
                          .Build();
        }
    }
}
