// ReSharper disable IdentifierTypo

namespace LeetCodeCSharpApp.OpenTheLock01;

public class Solution
{
    public int OpenLock(string[] deadends, string target)
    {
        var deadSet = new HashSet<string>(deadends);

        if (deadSet.Contains("0000"))
            return -1;

        var queue = new Queue<string>();
        queue.Enqueue("0000");

        var steps = 0;

        while (queue.Count > 0)
        {
            int queueSize = queue.Count;

            for (var i = 0; i < queueSize; i++)
            {
                string current = queue.Dequeue();

                if (current == target)
                    return steps;

                var neighbors = GetNeighbors(current)
                    .Where(n => deadSet.Add(n));

                foreach (string neighbor in neighbors)
                    queue.Enqueue(neighbor);
            }

            steps++;
        }

        return -1;
    }

    private static List<string> GetNeighbors(string code)
    {
        var result = new List<string>();

        for (var i = 0; i < 4; i++)
        {
            int currentDigit = code[i] - '0';

            for (int diff = -1; diff <= 1; diff += 2)
            {
                int newDigit = (currentDigit + diff + 10) % 10;
                string newCombination = code[..i] + newDigit + code[(i + 1)..];
                result.Add(newCombination);
            }
        }

        return result;
    }
}