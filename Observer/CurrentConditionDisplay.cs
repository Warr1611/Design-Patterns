public class CurrentConditionDisplay : Observer, DisplayElement {
    private float temperature;
    private float humidity;
    private Subject weatherData;

    public CurrentConditionDisplay(Subject weatherData) {
        weatherData = weatherData;
        weatherData.registerObserver(this);
    }

    public void update(Subject s) {
        WeatherData wd = (WeatherData)s;
        temperature = s.temperature;
        humidity = s.humidity;
        display();
    }

    public void display() {
        Console.WriteLine("Current conditions: " + temperature + "F and " + humidity + "% humidity");
    }
}