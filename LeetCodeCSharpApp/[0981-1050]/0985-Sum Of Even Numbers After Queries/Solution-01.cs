namespace LeetCodeCSharpApp.SumOfEvenNumbersAfterQueries01;

public class Solution
{
    public int[] SumEvenAfterQueries(int[] nums, int[][] queries)
    {
        var result = new int[nums.Length];
        var oddNumbersSum = nums.Sum(n => n % 2 == 0 ? n : 0);

        for (var i = 0; i < queries.Length; i++)
        {
            var index = queries[i][1];
            var val = queries[i][0];

            if (nums[index] % 2 == 0)
                oddNumbersSum -= nums[index];

            nums[index] += val;

            if (nums[index] % 2 == 0)
                oddNumbersSum += nums[index];

            result[i] = oddNumbersSum;
        }

        return result;
    }
}
