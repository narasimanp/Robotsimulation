namespace Robot_simulation_application;
using System;

class Program
{
    static void Main(string[] args)
    {

        ToyRobot toyRobot = new ToyRobot();

        ICommand[] commands =
        {
            new PlaceCommand(toyRobot, 0, 0, Direction.NORTH),
            new MoveCommand(toyRobot),
            new ReportCommand(toyRobot)
        };


        ICommand[] commands2 =
        {
            new PlaceCommand(toyRobot, 0, 0, Direction.NORTH),
            new LeftCommand(toyRobot),
            new ReportCommand(toyRobot)
        };

        CommandProcessor processor = new CommandProcessor(commands);
        processor.ProcessCommands();

        processor = new CommandProcessor(commands2);
        processor.ProcessCommands();

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
