namespace LeetCodeCSharpApp.MinimumAverageDifference01;

public class Solution
{
    public int MinimumAverageDifference(int[] nums)
    {
        int minAvg = int.MaxValue, result = -1, n = nums.Length;
        long rSum = 0, lSum = 0;
        lSum = nums.Aggregate(lSum, (current, num) => current + num);

        for (var i = 0; i < n; i++)
        {
            rSum += nums[i];
            lSum -= nums[i];

            var lAvg = (int)(rSum / (i + 1));
            var rAvg = i == n - 1 ? 0 : (int)(lSum / (n - i - 1));

            var curAvg = Math.Abs(lAvg - rAvg);

            if (curAvg >= minAvg)
                continue;

            minAvg = curAvg;
            result = i;
        }

        return result;
    }
}
