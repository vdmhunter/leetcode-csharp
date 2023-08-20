namespace LeetCodeCSharpApp.CheckIfAStringIsAnAcronymOfWords01;

public class Solution
{
    public bool IsAcronym(IList<string> words, string s)
    {
        return s == string.Join("", words.Select(ch => ch[0]));
    }
}
