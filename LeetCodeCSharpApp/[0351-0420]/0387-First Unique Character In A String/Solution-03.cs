namespace LeetCodeCSharpApp.FirstUniqueCharacterInAString03;

public class Solution
{
    public int FirstUniqChar(string s)
    {
        var dp = new int['z' - 'a' + 1];
        
        foreach (var c in s)
            dp[c - 'a']++;

        foreach (var c in s)
            if (dp[c - 'a'] == 1)
                return s.IndexOf(c);

        return -1;
    }
}
