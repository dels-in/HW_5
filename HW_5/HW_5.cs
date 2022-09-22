using HW_5;

var quadcopter = new Quadcopter();
quadcopter.GetComponents();

IChargeable charge = quadcopter;
charge.Charge();

IRobot robot = quadcopter;
Console.WriteLine(robot.GetRobotType());
robot.GetComponents();

IFlyingRobot flyingRobot = quadcopter;
Console.WriteLine(flyingRobot.GetRobotType());
