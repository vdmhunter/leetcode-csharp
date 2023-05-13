namespace LeetCodeCSharpApp.PowerOfHeroes01;

public class Solution
{
    private const long Mod = 1_000_000_007L;

    public int SumOfPower(int[] nums)
    {
        var result = 0L;
        var s = 0L;

        Array.Sort(nums);

        foreach (var n in nums)
        {
            result = (result + (s + n) * n % Mod * n % Mod) % Mod;
            s = (s * 2 + n) % Mod;
        }

        return (int)result;
    }
}
