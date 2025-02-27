using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemDesignLLD.Creational_Patterns.Factory_Patterns
{
    public class FactoryPattern
    {
        public  void MainMethod()
        {
            //Direct create objects
            //Transport vehicle = TransportFactory.createTransport("car");
            Transport vehicle = TransportFactory.createTransport("bike");
            vehicle.deliver();
        }

    }

    public interface Transport
    {
        void deliver();
    }

    public class Car : Transport
    {
        public void deliver()
        {
            Console.WriteLine("Delivered by car");
        }
    }

    public class Bike : Transport
    {
        public void deliver()
        {
            Console.WriteLine("Delivered by bike");
        }
    }

    public class Bus : Transport
    {
        public void deliver()
        {
            Console.WriteLine("Delivered by bus");
        }
    }

    public class TransportFactory
    {
        private static Dictionary<string, Transport> transoprts = new Dictionary<string, Transport>();

        static TransportFactory()
        {
            transoprts.Add("car", new Car());
            transoprts.Add("bike", new Bike());
            transoprts.Add("bus", new Bus());
        }

        // switch case approach 1
        //public static Transport createTransport(String type)
        //{


        //    switch (type.ToLower())
        //    {
        //        case "car":
        //            return new Car();
        //        case "bike":
        //            return new Bike();
        //        case "bus":
        //            return new Bus();
        //        default:
        //            throw new ArgumentException("Unsupported transport type");
        //    }

        //}

        // RIP :- Replace with If/switch with Polymorphism approach 2
        //public static Transport createTransport(String type)
        //{
        //    return transoprts[type.ToLower()];
        //}


        // lazy loading  approach 3

        private static Dictionary<string, Transport> transoprtsobj = new Dictionary<string, Transport>();
        public static Transport createTransport(String type)
        {
            if (transoprtsobj.Count == 0)
            {
                transoprtsobj.Add("car", new Car());
                transoprtsobj.Add("bike", new Bike());
                transoprtsobj.Add("bus", new Bus());
            }

            return transoprtsobj[type.ToLower()];
        }

    }

}
