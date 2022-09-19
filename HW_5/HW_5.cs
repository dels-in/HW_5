var iRobot = new Quadcopter();
iRobot.GetComponents();

//почему так можно
IChargeable charge = iRobot;
charge.Charge();

//а так нельзя?
//iRobot.Charge();

public interface IRobot
{
    public string GetInfo()
    {
        throw new NotImplementedException();
    }

    public List<string> GetComponents()
    {
        throw new NotImplementedException();
    }
    
    string GetRobotType()
    {
        return "I am a simple robot.";
    }
}

public interface IChargeable
{
    void Charge()
    {
        Console.WriteLine("Charging...");
        Thread.Sleep(3000);
        Console.Clear();
        Console.WriteLine("Charged!");
    }

    string GetInfo()
    {
        throw new NotImplementedException();
    }
}

public interface IFlyingRobot : IRobot
{
    string GetRobotType()
    {
        return "I am a flying robot.";
    }
}

public class Quadcopter : IFlyingRobot, IChargeable
{
    private List<string> _components = new(new[]{ "rotor1", "rotor2", "rotor3", "rotor4" });
    
    //не знаю, как передать значение поля _components родительскому интерфейсу, который вернет эту коллекцию
    //может, я неправильно понял задание
    public List<string> GetComponents()
    {
        return _components;
    }
}