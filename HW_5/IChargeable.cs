namespace HW_5;

public interface IChargeable
{
    void Charge()
    {
        var left = Console.CursorLeft;
        var top = Console.CursorTop;
        Console.WriteLine("Charging...");
        Thread.Sleep(3000);
        Console.SetCursorPosition(left, top);
        Console.Write(new string(' ', Console.WindowWidth)); 
        Console.SetCursorPosition(left, top);
        Console.WriteLine("Charged!");
    }

    string GetInfo()
    {
        throw new NotImplementedException();
    }
}