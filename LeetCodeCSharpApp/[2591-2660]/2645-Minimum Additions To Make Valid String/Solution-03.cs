namespace LeetCodeCSharpApp.MinimumAdditionsToMakeValidString03;

public class Solution
{
    public int AddMinimum(string word)
    {
        return 3 + word.Zip(word.Skip(1), (a, b) => a >= b ? 1 : 0).Sum() * 3 - word.Length;
    }
}
