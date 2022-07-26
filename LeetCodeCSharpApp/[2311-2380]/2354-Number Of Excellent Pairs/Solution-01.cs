namespace LeetCodeCSharpApp.NumberOfExcellentPairs01;

public class Solution
{
    public long CountExcellentPairs(int[] nums, int k)
    {
        var count = new long[30];
        var result = 0L;
        var set = new HashSet<int>();

        foreach (var n in nums)
            set.Add(n);

        foreach (var n in set)
            count[Convert.ToString(n, 2).ToCharArray().Count(i => i == '1')]++;

        for (var i = 1; i < 30; ++i)
            for (var j = 1; j < 30; ++j)
                if (i + j >= k)
                    result += count[i] * count[j];

        return result;
    }
}
