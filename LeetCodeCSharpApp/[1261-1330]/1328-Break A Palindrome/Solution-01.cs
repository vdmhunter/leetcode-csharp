namespace LeetCodeCSharpApp.BreakAPalindrome01;

public class Solution
{
    public string BreakPalindrome(string palindrome)
    {
        var s = palindrome.ToCharArray();
        var n = s.Length;

        for (var i = 0; i < n / 2; i++)
            if (s[i] != 'a')
            {
                s[i] = 'a';

                return new string(s);
            }

        s[n - 1] = 'b'; //if all 'a'

        return n < 2 ? "" : new string(s);
    }
}
