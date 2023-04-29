// ReSharper disable IdentifierTypo

namespace LeetCodeCSharpApp.DeleteColumnsToMakeSorted01;

public class Solution
{
    public int MinDeletionSize(string[] strs)
    {
        var result = strs[0].Length;

        for (var i = 0; i < strs[0].Length; i++)
        {
            var col = strs.Select(s => s[i]).ToArray();

            if (col.OrderBy(c => c).SequenceEqual(col))
                result--;
        }

        return result;
    }
}
