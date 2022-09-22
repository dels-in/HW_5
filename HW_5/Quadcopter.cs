namespace HW_5;

public class Quadcopter : IFlyingRobot, IChargeable
{
    private List<string> _components = new(new[]{ "rotor1", "rotor2", "rotor3", "rotor4" });
    
    //не знаю, как передать значение поля _components родительскому интерфейсу, который вернет эту коллекцию
    //может, я неправильно понял задание
    
    public List<string> GetComponents()
    {
        foreach (string i in _components)
            Console.WriteLine(i);
        return _components;
    }
}