using System.Text;

namespace LeetCodeCSharpApp.FindTheStringWithLCP01;

public class Solution
{
    public string FindTheString(int[][] lcp)
    {
        int n = lcp.Length, c = 0;
        var arr = new int[n];

        for (var i = 0; i < n; ++i)
        {
            if (arr[i] > 0)
                continue;

            if (++c > 26)
                return "";

            for (var j = i; j < n; ++j)
                if (lcp[i][j] > 0)
                    arr[j] = c;
        }

        for (var i = 0; i < n; ++i)
            for (var j = 0; j < n; ++j)
            {
                var v = i + 1 < n && j + 1 < n ? lcp[i + 1][j + 1] : 0;
                v = arr[i] == arr[j] ? v + 1 : 0;

                if (lcp[i][j] != v)
                    return "";
            }

        var result = new StringBuilder();

        foreach (var a in arr)
            result.Append((char)('a' + a - 1));

        return result.ToString();
    }
}
