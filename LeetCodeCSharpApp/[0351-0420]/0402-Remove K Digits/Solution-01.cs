// ReSharper disable IdentifierTypo

using System.Text;

namespace LeetCodeCSharpApp.RemoveKDigits01;

public class Solution
{
    public string RemoveKdigits(string num, int k)
    {
        var result = new StringBuilder();

        foreach (var ch in num)
        {
            while (result.Length > 0 && result[^1] > ch && k > 0)
            {
                result.Remove(result.Length - 1, 1);
                k--;
            }

            if (result.Length > 0 || ch != '0')
                result.Append(ch);
        }

        while (result.Length > 0 && k-- > 0)
            result.Remove(result.Length - 1, 1);

        return result.Length == 0 ? "0" : result.ToString();
    }
}
