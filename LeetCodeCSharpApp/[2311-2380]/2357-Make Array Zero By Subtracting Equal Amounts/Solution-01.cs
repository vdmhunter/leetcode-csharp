namespace LeetCodeCSharpApp.MakeArrayZeroBySubtractingEqualAmounts01;

public class Solution
{
    public int MinimumOperations(int[] nums)
    {
        var n = 0;

        while (true)
        {
            nums = nums.Where(i => i > 0).ToArray();

            if (nums.Length == 0)
                break;

            var min = nums.Min();
            nums = nums.Select(i => i - min < 0 ? 0 : i - min).ToArray();
            n++;
        }

        return n;
    }
}
