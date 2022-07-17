namespace LeetCodeCSharpApp.MinimumDeletionsToMakeArrayDivisible01;

public class Solution
{
    public int MinOperations(int[] nums, int[] numsDivide)
    {
        var g = numsDivide[0];

        g = numsDivide.Aggregate(g, Gcd);

        Array.Sort(nums);

        for (var i = 0; i < nums.Length && nums[i] <= g; ++i)
            if (g % nums[i] == 0)
                return i;

        return -1;
    }
    
    private static int Gcd(int a, int b)
    {
        return b == 0 ? a : Gcd(b, a % b);
    }
}
