using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemDesignLLD.BehaviouralPatterns.Observer_Pattern
{
    public interface Observer
    {
        void update(float temp);
    }

    public class Mobile : Observer
    {
        private string name = string.Empty;
        public Mobile(string name)
        {
            name = name;
        }
        public void update(float temp)
        {
            Console.WriteLine("Temperature on " + name + " mobile is : " + temp);
        }
    }

    public class Tablet : Observer
    {
        private string name = string.Empty;
        public Tablet(string name)
        {
            this.name = name;
        }
        public void update(float temp)
        {
            Console.WriteLine("Temperature on " + name + " tablet is : " + temp);
        }
    }

}
