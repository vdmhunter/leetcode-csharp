namespace LeetCodeCSharpApp.PalindromeNumber01;

public class Solution
{
    public bool IsPalindrome(int x)
    {
        var s = x.ToString();
        return s.SequenceEqual(s.Reverse());
    }
}
