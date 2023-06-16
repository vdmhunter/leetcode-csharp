namespace LeetCodeCSharpApp.NumberOfWaysToReorderArrayToGetSameBST02;

public class Solution
{
    private const int Mod = 1_000_000_007;

    public int NumOfWays(int[] nums)
    {
        return (int)GetCombs(nums, GetTriangle(nums.Length + 1)) - 1;
    }

    private static long GetCombs(int[] nums, long[,] combs)
    {
        if (nums.Length <= 2)
            return 1;

        var root = nums[0];
        var left = new List<int>();
        var right = new List<int>();

        foreach (var n in nums)
            if (n < root)
                left.Add(n);
            else if (n > root)
                right.Add(n);

        return combs[left.Count + right.Count, left.Count] * (GetCombs(left.ToArray(), combs) % Mod) % Mod *
            GetCombs(right.ToArray(), combs) % Mod;
    }

    private static long[,] GetTriangle(int n)
    {
        var triangle = new long[n, n];

        for (var i = 0; i < n; i++)
            triangle[i, 0] = triangle[i, i] = 1;

        for (var i = 2; i < n; i++)
            for (var j = 1; j < i; j++)
                triangle[i, j] = (triangle[i - 1, j] + triangle[i - 1, j - 1]) % Mod;

        return triangle;
    }
}
