namespace LeetCodeCSharpApp.RomanToInteger01;

public class Solution
{
    public int RomanToInt(string s)
    {
        var map = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        int max = map[s[^1]], result = 0;
        
        for (var i = s.Length - 1; i >= 0; --i)
            if (max <= map[s[i]])
            {
                max = Math.Max(max, map[s[i]]);
                result += map[s[i]];
            }
            else
                result -= map[s[i]];

        return result;
    }
}
