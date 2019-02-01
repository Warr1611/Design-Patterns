using System;

namespace Observer
{
    public class CurrentConditionDisplay : Observer, DisplayElement {
        private float temperature;
        private float humidity;
        private Subject weatherData;

        public CurrentConditionDisplay(Subject weatherData) {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }

        public void update(Subject s) {
            WeatherData wd = (WeatherData)s;
            temperature = wd.temperature;
            humidity = wd.humidity;
            display();
        }

        public void display() {
            Console.WriteLine("Current conditions: " + temperature + "F and " + humidity + "% humidity");
        }
    }
}