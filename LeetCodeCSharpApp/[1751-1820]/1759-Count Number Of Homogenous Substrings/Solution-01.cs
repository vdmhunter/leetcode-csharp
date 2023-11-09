namespace LeetCodeCSharpApp.CountNumberOfHomogenousSubstrings01;

public class Solution
{
    private const int Mod = 1_000_000_007;

    public int CountHomogenous(string s)
    {
        int result = 0, current = 0, count = 0;

        foreach (var ch in s)
        {
            count = ch == current ? count + 1 : 1;
            current = ch;
            result = (result + count) % Mod;
        }

        return result;
    }
}
