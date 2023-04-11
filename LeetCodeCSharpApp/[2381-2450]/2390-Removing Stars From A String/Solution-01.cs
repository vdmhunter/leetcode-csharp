using System.Text;

namespace LeetCodeCSharpApp.RemovingStarsFromAString01;

public class Solution
{
    public string RemoveStars(string s)
    {
        var res = new StringBuilder();

        foreach (var c in s)
            if (c == '*')
                res.Length--;
            else
                res.Append(c);

        return res.ToString();
    }
}
