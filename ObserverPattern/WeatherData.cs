using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class WeatherData : Subject
    {
        private List<Observer> observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = new List<Observer>();
        }
        public void NotifyObservers()
        {
            // TODO: Loop through the observers and call Update() with the appropriate fields
        }

        public void RegisterObserver(Observer o)
        {
            // TODO: Add o to the list of observers
        }

        public void RemoveObserver(Observer o)
        {
            // TODO: Remover o from the list of observers

        }

        public void MeasurementChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float tempereature, float humidity, float pressure)
        {
            this.temperature = tempereature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementChanged();
        }
    }
}
