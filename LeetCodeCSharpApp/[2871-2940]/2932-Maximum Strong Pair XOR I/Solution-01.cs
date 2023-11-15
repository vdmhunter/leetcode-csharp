namespace LeetCodeCSharpApp.MaximumStrongPairXOR_I01;

public class Solution
{
    public int MaximumStrongPairXor(int[] nums)
    {
        return nums.SelectMany(x => nums, (x, y) => new { x, y })
            .Where(pair => Math.Abs(pair.x - pair.y) <= Math.Min(pair.x, pair.y))
            .Max(pair => pair.x ^ pair.y);
    }
}
