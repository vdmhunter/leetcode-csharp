namespace LeetCodeCSharpApp.MaximumIceCreamBars01;

public class Solution
{
    public int MaxIceCream(int[] costs, int coins)
    {
        var result = 0;
        PriorityQueue<int, int> q = new(costs.Select(x => (x, x)));

        while (q.Count > 0 && coins >= q.Peek())
        {
            coins -= q.Dequeue();
            result++;
        }

        return result;
    }
}
