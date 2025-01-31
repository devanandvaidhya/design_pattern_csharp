using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemDesignLLD.BehaviouralPatterns.Observer_Pattern
{
    public interface Subject
    {
        void attach(Observer observer);
        void detach(Observer observer);
        void notifyObserver();
    }

    class WeatherStation : Subject
    {
        private float Temperature;
       private List<Observer> observerslist    = new List<Observer>();

        public void attach(Observer observer)
        {
            observerslist.Add(observer);
        }

        public void detach(Observer observer)
        {
            observerslist.Remove(observer);
        }

        public void setTemperature(float temperature) { 
        this.Temperature= temperature;
            notifyObserver();
        }
        public void notifyObserver()
        {
            foreach (Observer observer in observerslist)
            {
                observer.update(Temperature); // Runtime polymorphism
            }
        }
    }

}                                      
                                       