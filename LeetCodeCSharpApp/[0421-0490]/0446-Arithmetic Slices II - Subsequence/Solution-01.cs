namespace LeetCodeCSharpApp.ArithmeticSlicesIISubsequence01;

public class Solution
{
    public int NumberOfArithmeticSlices(int[] nums)
    {
        if (nums.Length < 3)
            return 0;

        var total = 0;
        var memo = new Dictionary<int, int>[nums.Length];
        
        for (var i = 0; i < nums.Length; i++)
            memo[i] = new Dictionary<int, int>();
        
        for (var i = 0; i < nums.Length; i++)
            for (var j = 0; j < i; j++)
            {
                var diffLong = (long)nums[i] - nums[j];

                if (diffLong is >= int.MaxValue or <= int.MinValue)
                    continue;

                var diff = (int)diffLong;
                memo[i].TryGetValue(diff, out var countI);
                memo[j].TryGetValue(diff, out var countJ);
                memo[i][diff] = countI + countJ + 1;
                total += countJ;
            }

        return total;
    }
}
