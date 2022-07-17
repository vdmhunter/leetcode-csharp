namespace LeetCodeCSharpApp.JumpGameVI01;

public class Solution
{
    public int MaxResult(int[] nums, int k)
    {
        var linkedList = new LinkedList<(int, int)>();
        linkedList.AddFirst((0, nums[0]));

        var max = nums[0];

        for (var i = 1; i < nums.Length; i++)
        {
            while (linkedList.Count != 0 && linkedList.First!.Value.Item1 < i - k)
                linkedList.RemoveFirst();

            max = nums[i] + (linkedList.Count == 0 ? 0 : linkedList.First!.Value.Item2);

            while (linkedList.Count != 0 && linkedList.Last!.Value.Item2 <= max)
                linkedList.RemoveLast();

            linkedList.AddLast((i, max));
        }

        return max;
    }
}
