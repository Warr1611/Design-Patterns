public class WeatherData : Subject {
    private List<Observer> observers;
    private float temperature;
    private float humidity;
    private float pressure;

    public WeatherData() {
        observers = new List<Observer>();
    }

    public void registerObserver(Observer o) {
        observers.Add(o);
    }

    public void removeObserver(Observer o) {
        // TODO: This is a Java implementation, convert to C# List syntax
        int i = observers.indexOf(o);
        if (i >= 0) {
            observers.Remove(i);
        }
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
        temperature = temperature;
        humidity = humidity;
        pressure = pressure;
        measurementsChanged();
    }
}