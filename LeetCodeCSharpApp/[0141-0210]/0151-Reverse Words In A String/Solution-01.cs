namespace LeetCodeCSharpApp.ReverseWordsInAString01;

public class Solution
{
    public string ReverseWords(string s)
    {
        var words = s.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(words);

        return string.Join(" ", words);
    }
}
