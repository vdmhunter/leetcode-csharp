namespace LeetCodeCSharpApp.NextGreaterElementI01;

public class Solution
{
    public int[] NextGreaterElement(int[] nums1, int[] nums2)
    {
        var map = new Dictionary<int, int>();
        var stack = new Stack<int>();

        foreach (var num in nums2)
        {
            while (stack.Count != 0 && stack.Peek() < num)
                map.Add(stack.Pop(), num);

            stack.Push(num);
        }

        for (var i = 0; i < nums1.Length; i++)
            nums1[i] = map.TryGetValue(nums1[i], out var value) ? value : -1;

        return nums1;
    }
}
