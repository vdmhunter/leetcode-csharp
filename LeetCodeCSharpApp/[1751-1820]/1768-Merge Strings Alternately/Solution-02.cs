namespace LeetCodeCSharpApp.MergeStringsAlternately02;

public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        return string.Concat(word1.Zip(word2, (a, b) => $"{a}{b}").SelectMany(x => x)) +
               (word1.Length > word2.Length ? word1[word2.Length..] : "") +
               (word2.Length > word1.Length ? word2[word1.Length..] : "");
    }
}
