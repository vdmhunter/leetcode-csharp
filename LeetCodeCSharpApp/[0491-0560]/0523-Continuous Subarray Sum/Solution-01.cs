namespace LeetCodeCSharpApp.ContinuousSubarraySum01;

public class Solution
{
    public bool CheckSubarraySum(int[] nums, int k)
    {
        var dictionary = new Dictionary<int, int> { { 0, -1 } };
        var runningSum = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            runningSum += nums[i];

            if (k != 0)
                runningSum %= k;

            if (dictionary.ContainsKey(runningSum))
            {
                if (i - dictionary[runningSum] > 1)
                    return true;
            }
            else
                dictionary.Add(runningSum, i);
        }

        return false;
    }
}
