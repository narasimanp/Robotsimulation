using Robot_simulation_application;
using NUnit.Framework;

namespace Unittestcases
{
    [TestFixture]
    public class ToyRobotTests
    {
        [Test]
        public void TestMoveNorth()
        {
    
            var robot = new ToyRobot();
            robot.Place(0, 0, Direction.NORTH);

            robot.Move();

            Assert.AreEqual("0,1,NORTH", robot.Report());
        }

        [Test]
        public void TestTurnLeft()
        {
            var robot = new ToyRobot();
            robot.Place(0, 0, Direction.NORTH);

            robot.TurnLeft();

            Assert.AreEqual("0,0,WEST", robot.Report());
        }
    }
}
