namespace LeetCodeCSharpApp.SumInAMatrix01;

public class Solution
{
    public int MatrixSum(int[][] nums)
    {
        var result = 0;

        foreach (var n in nums)
            Array.Sort(n);

        for (var i = 0; i < nums[0].Length; i++)
        {
            var max = int.MinValue;

            for (var j = 0; j < nums.Length; j++)
            {
                max = Math.Max(max, nums[j][i]);

                if (j == nums.Length - 1)
                    result += max;
            }
        }

        return result;
    }
}
