namespace LeetCodeCSharpApp.SquaresOfASortedArray02;

/// <summary>
///   Two Pointer
///
///   Time complexity: O(n)
///   Space complexity: O(n)
/// </summary>
public class Solution
{
    public int[] SortedSquares(int[] nums)
    {
        int n = nums.Length;
        int left = 0, right = n - 1;
        var result = new int[n];

        for (int i = n - 1; i >= 0; i--)
        {
            int square;

            if (Math.Abs(nums[left]) < Math.Abs(nums[right]))
            {
                square = nums[right];
                right--;
            }
            else
            {
                square = nums[left];
                left++;
            }

            result[i] = square * square;
        }

        return result;
    }
}
