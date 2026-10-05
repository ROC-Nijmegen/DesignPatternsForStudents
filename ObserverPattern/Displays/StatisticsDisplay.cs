using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    // TODO: Inherit WeatherDisplay
    internal class StatisticsDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float sumTemperature = 0;
        private float maxTemp = 0;
        private float minTemp = 0;
        private int countUpdated = 0;
        private Subject weatherData;
        public StatisticsDisplay(Subject weatherData) 
        {
            // TODO: Set the field and register itself with the weatherdata subject
        }
        public void Update(float temp, float humidity, float pressure)
        {
            // TODO: Set the correct fields with the relevant parameters
            Display(); // Notice how we're calling Display() in EVERY display subclass?
        }

        public void Display()
        {
            // TODO: Print the average, maximum and minimum temperature. Use appropriate fields
        }
    }
}
