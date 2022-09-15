namespace LeetCodeCSharpApp.FindOriginalArrayFromDoubledArray02;

public class Solution
{
    public int[] FindOriginalArray(int[] changed)
    {
        if (changed.Length % 2 != 0)
            return Array.Empty<int>();

        var indexesLength = changed.Max() + 1;
        var indexes = new int[indexesLength];
        var result = new List<int>();

        foreach (var n in changed)
            indexes[n]++;

        for (var i = 0; i < indexes.Length; i++)
        {
            if (indexes[i] == 0)
                continue;

            var doubled = i * 2;

            if (doubled < indexesLength && indexes[doubled] > 0)
            {
                result.Add(i);
                indexes[i]--;
                indexes[doubled]--;
                i--;
            }
            else
            {
                return Array.Empty<int>();
            }
        }

        return result.ToArray();
    }
}
