using System.Text;

namespace LeetCodeCSharpApp.MergeStringsAlternately01;

public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        int n = word1.Length, m = word2.Length, i = 0, j = 0;
        var res = new StringBuilder();
        
        while (i < n || j < m)
        {
            if (i < word1.Length)
                res.Append(word1[i++]);
            
            if (j < word2.Length)
                res.Append(word2[j++]);
        }

        return res.ToString();
    }
}
