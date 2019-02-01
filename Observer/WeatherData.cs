using System.Collections.Generic;

namespace Observer
{
    public class WeatherData : Subject {
        private List<Observer> observers;
        public float temperature;
        public float humidity;
        public float pressure;

        public WeatherData() {
            observers = new List<Observer>();
        }

        public void registerObserver(Observer o) {
            observers.Add(o);
        }

        public void removeObserver(Observer o) {
            observers.Remove(o);
        }

        public void notifyObservers() {
            foreach (Observer o in observers) {
                o.update(this);
            }
        }

        public void measurementsChanged() {
            notifyObservers();
        }

        public void setMeasurements(float temperature, float humidity, float pressure) {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            measurementsChanged();
        }
    }
}