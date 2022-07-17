namespace LeetCodeCSharpApp.ShortEncodingOfWords01;

/// <summary>
/// Store Prefixes
/// </summary>
public class Solution 
{
    public int MinimumLengthEncoding(string[] words)
    {
        var good = new HashSet<string>(words);
        
        foreach (var word in words)
            for (var k = 1; k < word.Length; ++k)
                good.Remove(word[k..]);

        return good.Sum(word => word.Length + 1);
    }
}
