namespace LeetCodeCSharpApp.FindFirstAndLastPositionOfElementInSortedArray01;

public class Solution
{
    public int[] SearchRange(int[] nums, int target)
    {
        var leftComparer = Comparer<int>.Create((a, b) => a == b ? 1 : a.CompareTo(b));
        var rightComparer = Comparer<int>.Create((a, b) => a == b ? -1 : a.CompareTo(b));

        var left = ~Array.BinarySearch(nums, target, leftComparer);
        var right = ~Array.BinarySearch(nums, target, rightComparer) - 1;

        return new[]
        {
            left < nums.Length && nums[left] == target ? left : -1,
            right >= 0 && nums[right] == target ? right : -1
        };
    }
}
