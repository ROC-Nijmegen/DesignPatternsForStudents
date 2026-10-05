using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    // TODO: Inherit WeatherDisplay
    internal class ForecastDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        private Subject weatherData;
        public ForecastDisplay(Subject weatherData) 
        
            // TODO: Set the field and register itself with the weatherdata subject
        }
        public void Update(float temp, float humidity, float pressure)
        {
            // TODO: Set the correct fields with the relevant parameters
            Display(); // Notice how we're calling Display() in EVERY display subclass?
        }

        public void Display()
        {
            // TODO: Print a forecast message based on the current temperature and humidity
        }
    }
}
