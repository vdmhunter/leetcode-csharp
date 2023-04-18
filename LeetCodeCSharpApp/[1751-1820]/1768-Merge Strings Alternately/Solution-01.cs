using System.Text;

namespace LeetCodeCSharpApp.MergeStringsAlternately01;

public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        int n = word1.Length, m = word2.Length, i = 0, j = 0;
        var result = new StringBuilder();

        while (i < n || j < m)
        {
            if (i < word1.Length)
                result.Append(word1[i++]);

            if (j < word2.Length)
                result.Append(word2[j++]);
        }

        return result.ToString();
    }
}
