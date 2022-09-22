namespace HW_5;

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