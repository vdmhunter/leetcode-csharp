namespace LeetCodeCSharpApp.PalindromicSubstrings02;

public class Solution
{
    public int CountSubstrings(string s)
    {
        var count = 0;

        for (var i = 0; i < s.Length; i++)
        {
            var l = i;
            var r = i;

            while (l >= 0 && r < s.Length && s[l] == s[r])
            {
                count++;
                l--;
                r++;
            }

            l = i;
            r = i + 1;

            while (l >= 0 && r < s.Length && s[l] == s[r])
            {
                count++;
                l--;
                r++;
            }
        }

        return count;
    }
}
