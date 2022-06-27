// ReSharper disable CommentTypo
// ReSharper disable IdentifierTypo

namespace LeetCodeCSharpApp.LongestCommonPrefix01;

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        var result = string.Empty;
        var shortest = strs.MinBy(s => s.Length); //strs.OrderBy(s => s.Length).FirstOrDefault()

        foreach (var c in shortest!)
        {
            result += c;
            if (!strs.All(s => s.StartsWith(result)))
                return result[..^1];
        }

        return result;
    }
}
