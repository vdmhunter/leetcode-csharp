namespace LeetCodeCSharpApp.SquaresOfASortedArray01;

/// <summary>
///   Sort
///
///   Time complexity: O(n * log(n))
///   Space complexity: O(n)
/// </summary>
public class Solution
{
    public int[] SortedSquares(int[] nums)
    {
        int n = nums.Length;
        var result = new int[n];

        for (var i = 0; i < n; i++)
            result[i] = nums[i] * nums[i];

        Array.Sort(result);

        return result;
    }
}
