namespace LeetCodeCSharpApp.MaximumNumberOfVowelsInASubstringOfGivenLength01;

public class Solution
{
    public int MaxVowels(string s, int k)
    {
        var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
        int result = 0, count = 0;

        for (var i = 0; i < s.Length; i++)
        {
            if (vowels.Contains(s[i]))
                count++;

            if (i >= k && vowels.Contains(s[i - k]))
                count--;

            result = Math.Max(count, result);
        }

        return result;
    }
}
