public void Main(){
    WeatherData weatherData = new WeatherData();

    CurrentConditionDisplay cd = new CurrentConditionDisplay(weatherData);

    weatherData.setMeasurements(80, 65, 30.4);
    weatherData.setMeasurements(82, 70, 29.2);
    weatherData.setMeasurements(78, 90, 29.2);
}