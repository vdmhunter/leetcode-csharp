namespace LeetCodeCSharpApp.FindThePivotInteger01;

/// <summary>
///   Using Math
///
///   Time complexity: O(1)
///   Space complexity: O(1)
/// </summary>
public class Solution
{
    public int PivotInteger(int n)
    {
        int sum = n * (n + 1) / 2;
        var pivot = (int)Math.Sqrt(sum);

        return pivot * pivot == sum ? pivot : -1;
    }
}
