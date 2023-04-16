namespace LeetCodeCSharpApp.MinimumAdditionsToMakeValidString02;

public class Solution
{
    public int AddMinimum(string word)
    {
        return 3 + Enumerable.Range(0, word.Length - 1).Count(i => word[i] >= word[i + 1]) * 3 - word.Length;
    }
}
