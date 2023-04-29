namespace LeetCodeCSharpApp.ReduceArraySizeToTheHalf01;

public class Solution
{
    public int MinSetSize(int[] arr)
    {
        var cnt = 0;

        return arr
            .GroupBy(x => x)
            .Select(x => x.Count())
            .OrderByDescending(x => x)
            .TakeWhile(x => (cnt += x) < arr.Length / 2)
            .Count() + 1;
    }
}
