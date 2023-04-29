namespace LeetCodeCSharpApp.MaximumNumberOfPairsInArray01;

public class Solution
{
    public int[] NumberOfPairs(int[] nums)
    {
        var list = new List<int>(nums);
        var count = 0;

        for (var i = list.Count; i > 0; --i)
        {
            var n = list[^i];
            var idx = list.IndexOf(n, list.Count - i + 1);

            if (idx == -1)
                continue;

            list.RemoveAt(idx);
            list.RemoveAt(0);
            i -= 1;
            count++;
        }

        return new[] { count, list.Count };
    }
}
