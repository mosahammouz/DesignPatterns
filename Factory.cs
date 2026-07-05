namespace DesignPatternsNotion;

public interface IVehicle
{
    void Drive();
}

public class Car : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Car is running");
    }
}

public class MotorCycle : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("MotorCycle is running");
    }
}


public abstract class VehicleFactory // abstract means => It is a base class that other classes inherit from.// and u must not init. it
{
    public abstract IVehicle CreatedVehicle(); // return obj maybe Car or MotorCycle

    public void DeliverVehicle()
    {
        IVehicle vehicle = CreatedVehicle(); // obj and its type (Car,MotorCycle)//The factory decides the actual object at runtime.
        Console.WriteLine("Vehicle created and ready for delivery!");
        vehicle.Drive();
    }

}

public class CarFactory : VehicleFactory
{
    public override IVehicle CreatedVehicle()
    {
        return new Car();
    }
    
}

public class MotorCycleFactory : VehicleFactory
{
    public override IVehicle CreatedVehicle()
    {
        return new MotorCycle();
    }
}
