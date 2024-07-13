// ReSharper disable SuggestVarOrType_SimpleTypes
// ReSharper disable SuggestVarOrType_Elsewhere

namespace LeetCodeCSharpApp.RobotCollisions01;

public class Solution
{
    public IList<int> SurvivedRobotsHealths(int[] positions, int[] healths, string directions)
    {
        var robots = positions
            .Select((p, i) => new Robot(p, healths[i], directions[i], i))
            .OrderBy(r => r.Position)
            .ToList();

        var stack = new Stack<Robot>();

        foreach (var robot in robots)
        {
            if (robot.Direction == 'R' || stack.Count == 0 || stack.Peek().Direction == 'L')
                stack.Push(robot);
            else
                HandleCollision(stack, robot);
        }

        return stack.OrderBy(r => r.Index).Select(r => r.Health).ToList();
    }

    private static void HandleCollision(Stack<Robot> stack, Robot currentRobot)
    {
        while (stack.Count > 0 && stack.Peek().Direction == 'R')
        {
            var lastRobot = stack.Pop();

            if (currentRobot.Health > lastRobot.Health)
            {
                currentRobot.Health -= 1;
            }
            else if (currentRobot.Health < lastRobot.Health)
            {
                lastRobot.Health -= 1;
                stack.Push(lastRobot);

                return;
            }
            else
            {
                return;
            }
        }

        stack.Push(currentRobot);
    }

    private struct Robot(int position, int health, char direction, int index)
    {
        public readonly int Position = position;
        public int Health = health;
        public readonly char Direction = direction;
        public readonly int Index = index;
    }
}
