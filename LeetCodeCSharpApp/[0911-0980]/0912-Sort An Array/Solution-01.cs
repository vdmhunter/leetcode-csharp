namespace LeetCodeCSharpApp.SortAnArray01;

public class Solution
{
    public int[] SortArray(int[] nums)
    {
        var sort = new PriorityQueue<int, int>();
        var output = new int[nums.Length];

        foreach (var n in nums)
            sort.Enqueue(n, n);

        for (var j = 0; j < nums.Length; j++)
            output[j] = sort.Dequeue();

        return output;
    }
}
