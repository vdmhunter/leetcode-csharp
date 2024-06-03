namespace LeetCodeCSharpApp.AppendCharactersToStringToMakeSubsequence01;

public class Solution
{
    public int AppendCharacters(string s, string t)
    {
        int n = t.Length;
        var idx = 0;

        foreach (char ch in s)
            if (ch == t[idx] && ++idx == n)
                return 0;

        return n - idx;
    }
}
