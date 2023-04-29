namespace LeetCodeCSharpApp.LongestPalindromeByConcatenatingTwoLetterWords01;

public class Solution
{
    public int LongestPalindrome(string[] words)
    {
        var counter = new int[26, 26];
        var result = 0;

        foreach (var item in words)
        {
            var a = item[0] - 97;
            var b = item[1] - 97;

            if (counter[b, a] > 0)
            {
                result += 4;
                counter[b, a]--;
            }
            else
                counter[a, b]++;
        }

        for (var i = 0; i < 26; i++)
            if (counter[i, i] > 0)
            {
                result += 2;
                break;
            }

        return result;
    }
}
