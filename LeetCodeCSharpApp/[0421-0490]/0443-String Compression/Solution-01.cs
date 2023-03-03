namespace LeetCodeCSharpApp.StringCompression01;

public class Solution
{
    public int Compress(char[] chars)
    {
        var i = 0;
        var j = 0;

        while (i < chars.Length)
        {
            var current = chars[i];
            var counter = 0;

            while (i < chars.Length && chars[i] == current)
            {
                i++;
                counter++;
            }

            chars[j++] = current;

            if (counter <= 1)
                continue;

            foreach (var counterChar in counter.ToString())
                chars[j++] = counterChar;
        }

        return j;
    }
}
