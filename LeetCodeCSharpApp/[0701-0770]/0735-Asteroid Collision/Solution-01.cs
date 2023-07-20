namespace LeetCodeCSharpApp.AsteroidCollision01;

public class Solution
{
    public int[] AsteroidCollision(int[] asteroids)
    {
        var stack = new Stack<int>();

        for (var i = 0; i < asteroids.Length; ++i)
        {
            while (stack.Count != 0 && asteroids[i] < 0 && stack.Peek() > 0)
            {
                var temp = asteroids[i] + stack.Peek();

                if (temp > 0)
                {
                    asteroids[i] = 0;
                }
                else if (temp < 0)
                {
                    stack.Pop();
                }
                else
                {
                    asteroids[i] = 0;
                    stack.Pop();
                }
            }

            Push(asteroids, i, stack);
        }

        var result = stack.ToArray();
        Array.Reverse(result);

        return result;
    }

    private static void Push(int[] asteroids, int i, Stack<int> stack)
    {
        if (asteroids[i] != 0)
            stack.Push(asteroids[i]);
    }
}
