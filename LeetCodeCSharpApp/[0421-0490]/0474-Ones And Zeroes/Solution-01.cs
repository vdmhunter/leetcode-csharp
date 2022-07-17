namespace LeetCodeCSharpApp.OnesAndZeroes01;

public class Solution
{
    // ReSharper disable once IdentifierTypo
    public int FindMaxForm(string[] strs, int m, int n)
    {
        var a = new int[m + 1, n + 1];

        foreach (var s in strs)
        {
            var n1 = s.Count(x => x == '1');
            var n0 = s.Length - n1;
            
            for (var i = m; i >= n0; i--)
            for (var j = n; j >= n1; j--)
                a[i, j] = Math.Max(a[i, j], 1 + a[i - n0, j - n1]);
        }

        return a[m, n];
    }
}
