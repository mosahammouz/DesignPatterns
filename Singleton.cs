namespace DesignPatternsNotion;

public sealed class Singleton
{
    private static Singleton _instance;
    private static readonly object _lock = new object(); //a shared “key”
    private Singleton(){} // private constr. prevents instantiation from other classes.
    public static Singleton Instance { // it's a prop. its data type Singleton and called Instance
        get
        {
            if (_instance == null)
            {   // 2 states for lock (1) Acquire lock (2) Release lock
                lock (_lock)  //Only one thread can enter this block at a time.
                {
                    if (_instance == null) _instance = new Singleton(); // critical section
                }
            }

            return _instance;
        }
    }

    public void DoSomething()
    {
        Console.WriteLine("Singleton method executed!");
    }
}