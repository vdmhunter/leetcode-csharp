namespace LeetCodeCSharpApp.LongestRepeatingCharacterReplacement01;

public class Solution
{
    public int CharacterReplacement(string s, int k)
    {
        int result = 0, max = 0;
        var count = new int[128];
        
        for (var i = 0; i < s.Length; ++i)
        {
            max = Math.Max(max, ++count[s[i]]);
            
            if (result - max < k)
                result++;
            else
                count[s[i - result]]--;
        }

        return result;
    }
}
