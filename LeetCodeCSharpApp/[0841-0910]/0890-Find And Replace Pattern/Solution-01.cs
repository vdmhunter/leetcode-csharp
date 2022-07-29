namespace LeetCodeCSharpApp.FindAndReplacePattern01;

public class Solution
{
    public IList<string> FindAndReplacePattern(string[] words, string pattern)
    {
        return words.Where(word =>
            (word.Distinct().Count() & pattern.Distinct().Count()) == word.Zip(pattern).Distinct().Count()).ToList();
    }
}
