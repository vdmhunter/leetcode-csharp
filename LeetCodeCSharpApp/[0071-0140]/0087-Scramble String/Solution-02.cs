namespace LeetCodeCSharpApp.ScrambleString02;

public class Solution
{
    private readonly Dictionary<string, bool> _d = new();

    public bool IsScramble(string s1, string s2)
    {
        return Check(s1, s2);
    }

    private bool Check(string s1, string s2)
    {
        if (s1.Length == 1)
            return s1 == s2;

        if (s1 == s2)
            return true;

        var dKey = s1 + "-" + s2;

        if (_d.TryGetValue(dKey, out var check))
            return check;

        var n = s1.Length;
        var f = new int[26];
        var s = new int[26];

        for (var i = 0; i < n; i++)
        {
            f[s1[i] - 'a']++;
            s[s2[i] - 'a']++;
        }

        if (string.Join('-', f) != string.Join('-', s))
        {
            _d[dKey] = false;

            return false;
        }

        for (var i = 1; i < n; i++)
            if (Check(s1[..i], s2[..i]) && Check(s1[i..], s2[i..]) ||
                Check(s1[..i], s2[(n - i)..]) && Check(s1[i..], s2[..(n - i)]))
            {
                _d[dKey] = true;

                return true;
            }

        _d[dKey] = false;

        return false;
    }
}
