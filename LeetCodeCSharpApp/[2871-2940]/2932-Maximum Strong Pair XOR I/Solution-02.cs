namespace LeetCodeCSharpApp.MaximumStrongPairXOR_I02;

public class Solution
{
    public int MaximumStrongPairXor(int[] nums)
    {
        var result = 0;

        foreach (var x in nums)
            foreach (var y in nums)
                if (Math.Abs(x - y) <= Math.Min(x, y))
                    result = Math.Max(result, x ^ y);

        return result;
    }
}
