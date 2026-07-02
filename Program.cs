using DesignPatternsNotion;

//Singleton s3 = new Singleton(); this is why constructor is private 
Singleton s1 = Singleton.Instance; //A thread is whatever is currently running this line.
s1.DoSomething();
Singleton s2 = Singleton.Instance;
Console.WriteLine($"are s1 and s2 both point to the same obj ? {ReferenceEquals(s1,s2)}");