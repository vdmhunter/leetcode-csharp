namespace LeetCodeCSharpApp.FindPolygonWithTheLargestPerimeter01;

/// <summary>
/// Time complexity: O(n * log(n))
/// Space complexity: O(log(n))
/// </summary>
public class Solution
{
    public long LargestPerimeter(int[] nums)
    {
        Array.Sort(nums);

        var result = -1L;
        var previousElementsSum = 0L;

        foreach (var num in nums)
        {
            if (num < previousElementsSum)
                result = num + previousElementsSum;

            previousElementsSum += num;
        }

        return result;
    }
}
