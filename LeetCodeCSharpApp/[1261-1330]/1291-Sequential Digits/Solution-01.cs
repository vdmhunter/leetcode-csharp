namespace LeetCodeCSharpApp.SequentialDigits01;

public class Solution
{
    public IList<int> SequentialDigits(int low, int high)
    {
        var result = new List<int>();
        var queue = new Queue<int>(Enumerable.Range(1, 9));

        while (queue.Count > 0)
        {
            var n = queue.Dequeue();

            if (low <= n && n <= high)
                result.Add(n);

            var last = n % 10;

            if (last < 9)
                queue.Enqueue(n * 10 + last + 1);
        }

        return result;
    }
}
