namespace LeetCodeCSharpApp.MovementOfRobots01;

public class Solution
{
    private const int Mod = 1_000_000_007;

    public int SumDistance(int[] nums, string s, int d)
    {
        for (var i = 0; i < nums.Length; i++)
            if (s[i] == 'R')
                nums[i] += d;
            else
                nums[i] -= d;

        var result = 0L;
        var pref = 0L;
        Array.Sort(nums);

        for (long i = 0; i < nums.Length; i++)
        {
            result += i * nums[i] - pref;
            result %= Mod;
            pref += nums[i];
        }

        return (int)result;
    }
}
