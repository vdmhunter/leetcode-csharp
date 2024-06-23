namespace LeetCodeCSharpApp.LongestContinuousSubarrayWithAbsoluteDiffLessThanOrEqualToLimit01;

public class Solution
{
    public int LongestSubarray(int[] nums, int limit)
    {
        var minDeque = new LinkedList<int>();
        var maxDeque = new LinkedList<int>();
        var maxLength = 0;
        var i = 0;

        for (var j = 0; j < nums.Length; j++)
        {
            AddToDeques(nums, j, minDeque, maxDeque);
            i = AdjustStartIndex(nums, limit, minDeque, maxDeque, i);
            maxLength = Math.Max(maxLength, j - i + 1);
        }

        return maxLength;
    }

    private static void AddToDeques(
        int[] nums,
        int j,
        LinkedList<int> minDeque,
        LinkedList<int> maxDeque)
    {
        while (maxDeque.Count > 0 && nums[maxDeque.Last!.Value] < nums[j])
            maxDeque.RemoveLast();

        maxDeque.AddLast(j);

        while (minDeque.Count > 0 && nums[minDeque.Last!.Value] > nums[j])
            minDeque.RemoveLast();

        minDeque.AddLast(j);
    }

    private static int AdjustStartIndex(
        int[] nums,
        int limit,
        LinkedList<int> minDeque,
        LinkedList<int> maxDeque,
        int i)
    {
        while (nums[maxDeque.First!.Value] - nums[minDeque.First!.Value] > limit)
        {
            if (maxDeque.First.Value == i)
                maxDeque.RemoveFirst();

            if (minDeque.First.Value == i)
                minDeque.RemoveFirst();

            i++;
        }

        return i;
    }
}
