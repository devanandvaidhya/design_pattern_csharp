using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemDesignLLD.BehaviouralPatterns.State_Pattern
{
    internal class StatePattern
    {
    }

    public interface TransportationMode
    {
        int CalculateETA();
        string GetDirection();

    }

    public class Car : TransportationMode
    {
        public int CalculateETA()
        {
            Console.WriteLine("Calculating ETA (Car)");
            return 20;
        }

        public string GetDirection()
        {
            return "Directions for driving";
        }
    }

    public class Cycling : TransportationMode
    {
        public int CalculateETA()
        {
            Console.WriteLine("Calculating ETA (Cycling)");
            return 30;
        }

        public string GetDirection()
        {
            return "Directions for Cycling";
        }
    }

    public class Walking : TransportationMode
    {
        public int CalculateETA()
        {
            Console.WriteLine("Calculating ETA (Walking)");
            return 50;
        }

        public string GetDirection()
        {
            return "Directions for Walking";
        }
    }

    public class TransportationService
    {
        TransportationMode transportationMode;
        public TransportationService( TransportationMode transportationMode)
        {
            this.transportationMode = transportationMode;
        }

        public void setTransportationMode(TransportationMode transportationMode)
        {
            this.transportationMode = transportationMode;
        }

        //delegating the work current state's concrete class

        public int getETA()
        {
            return transportationMode.CalculateETA();
        }

        public string GetDirection()
        {
            return transportationMode.GetDirection();
        }

    }


}
