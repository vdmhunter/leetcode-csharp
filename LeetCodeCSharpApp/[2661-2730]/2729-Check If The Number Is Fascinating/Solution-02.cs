namespace LeetCodeCSharpApp.CheckIfTheNumberIsFascinating02;

public class Solution
{
    public bool IsFascinating(int n)
    {
        var s = n + (n * 2).ToString() + n * 3;
        var hs = new HashSet<char>(s);

        return hs.Count == 9 && s.Length == 9 && !hs.Contains('0');
    }
}
