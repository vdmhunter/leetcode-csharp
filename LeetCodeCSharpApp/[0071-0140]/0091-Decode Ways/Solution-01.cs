namespace LeetCodeCSharpApp.DecodeWays01;

public class Solution
{
    public int NumDecodings(string s)
    {
        var n = s.Length;
        var mem = new int?[n];

        return s.Length == 0 ? 0 : NumDecodings(0, s, mem);
    }

    private int NumDecodings(int p, string s, int?[] mem)
    {
        var n = s.Length;

        if (p == n)
            return 1;

        if (s[p] == '0')
            return 0;

        if (mem[p] != null)
            return mem[p]!.Value;

        var result = NumDecodings(p + 1, s, mem);

        if (p < n - 1 && (s[p] == '1' || (s[p] == '2' && s[p + 1] < '7')))
            result += NumDecodings(p + 2, s, mem);

        mem[p] = result;

        return result;
    }
}
