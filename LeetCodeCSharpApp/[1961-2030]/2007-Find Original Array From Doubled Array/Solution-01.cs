namespace LeetCodeCSharpApp.FindOriginalArrayFromDoubledArray01;

public class Solution
{
    public int[] FindOriginalArray(int[] changed)
    {
        if (changed.Length % 2 == 1) // this is important for zeros
            return Array.Empty<int>();

        var count = new int[200001];
        foreach (var val in changed) ++count[val];

        List<int> result = new(Enumerable.Repeat(0, count[0] / 2)); // zero is special case

        for (var val = 1; val <= 100000; ++val)
        {
            if (count[val] == 0)
                continue;

            count[val * 2] -= count[val];

            if (count[val * 2] < 0)
                return Array.Empty<int>();

            result.AddRange(Enumerable.Repeat(val, count[val]));
        }

        return result.ToArray();
    }
}
