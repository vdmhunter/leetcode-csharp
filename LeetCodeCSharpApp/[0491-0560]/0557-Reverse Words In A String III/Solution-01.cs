using System.Text;

namespace LeetCodeCSharpApp.ReverseWordsInAStringIII01;

public class Solution
{
    public string ReverseWords(string s)
    {
        var result = new StringBuilder();

        foreach (var w in s.Split(' '))
        {
            result.Append(w.ToCharArray().Reverse().ToArray());
            result.Append(' ');
        }

        return result.ToString().TrimEnd();
    }
}
