namespace LeetCodeCSharpApp.DivisibilityArrayOfAString01;

public class Solution
{
    public int[] DivisibilityArray(string word, int m)
    {
        var n = word.Length;
        var result = new List<int>(n);
        var sm = 0L;
        
        for (var i = 0; i < n; i++)
        {
            sm = (sm * 10 + (word[i] - '0')) % m;
            result.Add(sm == 0 ? 1 : 0);
        }

        return result.ToArray();
    }
}
