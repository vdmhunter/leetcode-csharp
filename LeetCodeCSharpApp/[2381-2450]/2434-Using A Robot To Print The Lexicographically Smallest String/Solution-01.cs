using System.Text;

namespace LeetCodeCSharpApp.UsingARobotToPrintTheLexicographicallySmallestString01;

public class Solution
{
    public string RobotWithString(string s)
    {
        var stack = new Stack<char>();
        var result = new StringBuilder();
        var freq = new int[26];

        foreach (var c in s)
            freq[c - 'a']++;
        
        foreach (var c in s)
        {
            stack.Push(c);
            freq[c - 'a']--;

            while (stack.Count > 0 && stack.Peek() <= Low(freq))
            {
                var x = stack.Peek();
                result.Append(x);
                stack.Pop();
            }
        }

        return result.ToString();
    }

    /// <summary>
    /// Return the smallest char present
    /// </summary>
    private static char Low(int[] freq)
    {
        for (var i = 0; i < 26; i++)
            if (freq[i] != 0)
                return (char)('a' + i);

        return 'z';
    }
}
