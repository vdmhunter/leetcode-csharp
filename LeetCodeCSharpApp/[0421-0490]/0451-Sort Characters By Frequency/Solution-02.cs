using System.Text;

namespace LeetCodeCSharpApp.SortCharactersByFrequency02;

public class Solution
{
    public string FrequencySort(string s)
    {
        var counts = new int[256];

        foreach (var c in s)
            counts[c]++;
        
        var chars = new string[s.Length + 1];

        for (var i = 0; i < 256; i++)
        {
            if (counts[i] <= 0)
                continue;
            
            var cnt = counts[i];

            chars[cnt] ??= "";
            chars[cnt] += (char)i;
        }
        
        var output = new StringBuilder();

        for (var i = chars.Length - 1; i >= 0; i--)
            AppendEachXTimes(output, chars[i], i);

        return output.ToString();
    }

    private static void AppendEachXTimes(StringBuilder builder, string s, int times)
    {
        if (s == null)
            return;

        foreach (var c in s)
            for (var i = 0; i < times; i++)
                builder.Append(c);
    }
}

