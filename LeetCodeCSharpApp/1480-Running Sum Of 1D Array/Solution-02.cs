namespace LeetCodeCSharpApp.RunningSumOf1DArray02;

public class Solution
{
    public int[] RunningSum(int[] nums)
    {
        var timestamp = (int)Math.Truncate(Math.Log2(nums.Length)) + 1;
        var res = new int[timestamp + 1][];
        res[0] = nums;

        for (var i = 0; i < timestamp; i++)
        {
            res[i + 1] = new int[nums.Length];

            for (var j = 0; j < nums.Length; j++)
                if (j < (int)Math.Pow(2, i))
                    res[i + 1][j] = res[i][j];
                else
                    res[i + 1][j] = res[i][j] + res[i][j - (int)Math.Pow(2, i)];
        }

        return res[timestamp];
    }
}
