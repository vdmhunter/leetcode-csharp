namespace LeetCodeCSharpApp.ConstrainedSubsequenceSum01;

public class Solution
{
    public int ConstrainedSubsetSum(int[] nums, int k)
    {
        var dq = new LinkedList<int>();

        for (var i = 0; i < nums.Length; i++)
        {
            nums[i] += GetFirstValue(nums, dq);
            RemoveValues(nums, dq, i, k);

            if (nums[i] > 0)
                dq.AddLast(i);
        }

        return nums.Max();
    }

    private static int GetFirstValue(int[] nums, LinkedList<int> dq)
    {
        return dq.Count > 0 ? nums[dq.First!.Value] : 0;
    }

    private static void RemoveValues(int[] nums, LinkedList<int> dq, int i, int k)
    {
        while (dq.Count > 0 && (i - dq.First!.Value >= k || nums[i] >= nums[dq.Last!.Value]))
            if (nums[i] >= nums[dq.Last!.Value])
                dq.RemoveLast();
            else
                dq.RemoveFirst();
    }
}
