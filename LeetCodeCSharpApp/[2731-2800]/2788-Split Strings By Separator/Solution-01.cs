namespace LeetCodeCSharpApp.SplitStringsBySeparator01;

public class Solution
{
    public IList<string> SplitWordsBySeparator(IList<string> words, char separator)
    {
        var result = new List<string>();

        foreach (var word in words)
        {
            var splitWords = word.Split(separator).Where(w => !string.IsNullOrEmpty(w));
            result.AddRange(splitWords);
        }

        return result;
    }
}
