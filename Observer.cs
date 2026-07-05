namespace DesignPatternsNotion;
// Observer interface
public interface IObserver
{
    void Update(string message);
}

// Subject class
public class WeatherStation
{
    private readonly List<IObserver> _observers = new List<IObserver>(); // it contains objects that implement IObserver
    private string _weatherUpdate;
    
    public void RegisterObserver(IObserver observer)
    {
        _observers.Add(observer);
    }
    
    public void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }
    
    public void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Update(_weatherUpdate);
        }
    }
    
    public void SetWeatherUpdate(string weatherUpdate)
    {
        _weatherUpdate = weatherUpdate;
        NotifyObservers();
    }
}

// Concrete observer classes
public class NewsAgency : IObserver
{
    private readonly string _name;
    
    public NewsAgency(string name)
    {
        _name = name;
    }
    
    public void Update(string message)
    {
        Console.WriteLine($"{_name} received weather update: {message}");
    }
}