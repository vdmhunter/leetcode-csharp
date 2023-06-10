namespace LeetCodeCSharpApp.MaximumValueAtAGivenIndexInABoundedArray01;

public class Solution
{
    public int MaxValue(int n, int index, int maxSum)
    {
        maxSum -= n;
        int left = 0, right = maxSum;

        while (left < right)
        {
            var mid = (left + right + 1) / 2;

            if (Test(n, index, mid) <= maxSum)
                left = mid;
            else
                right = mid - 1;
        }

        return left + 1;
    }

    private static long Test(int n, int index, int a)
    {
        var b = Math.Max(a - index, 0);
        var result = (long)(a + b) * (a - b + 1) / 2;
        b = Math.Max(a - (n - 1 - index), 0);
        result += (long)(a + b) * (a - b + 1) / 2;

        return result - a;
    }
}
