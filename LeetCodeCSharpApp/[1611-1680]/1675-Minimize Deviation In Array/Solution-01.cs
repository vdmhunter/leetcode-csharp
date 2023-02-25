namespace LeetCodeCSharpApp.MinimizeDeviationInArray01;

public class Solution
{
    public int MinimumDeviation(int[] nums)
    {
        var pq = new PriorityQueue<int, int>();
        var minVal = int.MaxValue;

        foreach (var num in nums)
        {
            var tmp = num;

            if (tmp % 2 == 1)
                tmp *= 2;

            pq.Enqueue(tmp, -tmp);
            minVal = Math.Min(minVal, tmp);
        }

        var minDeviation = int.MaxValue;

        while (true)
        {
            var maxVal = pq.Dequeue();
            minDeviation = Math.Min(minDeviation, maxVal - minVal);

            if (maxVal % 2 == 1)
                break;

            maxVal /= 2;
            minVal = Math.Min(minVal, maxVal);
            pq.Enqueue(maxVal, -maxVal);
        }

        return minDeviation;
    }
}
