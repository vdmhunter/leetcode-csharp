namespace LeetCodeCSharpApp.MaximumStrengthOfAGroup01;

public class Solution
{
    public long MaxStrength(int[] nums)
    {
        var n = nums.Length;
        var maxStrength = long.MinValue;

        for (var i = 1; i < 1 << n; i++)
        {
            var strength = 1L;

            for (var j = 0; j < n; j++)
                if ((i & 1 << j) != 0)
                    strength *= nums[j];

            maxStrength = Math.Max(maxStrength, strength);
        }

        return maxStrength;
    }
}
