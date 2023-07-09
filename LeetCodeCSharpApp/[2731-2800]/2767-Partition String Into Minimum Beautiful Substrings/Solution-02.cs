namespace LeetCodeCSharpApp.PartitionIntoMinimumBeautifulSubstrings02;

public class Solution
{
    public int MinimumBeautifulSubstrings(string s)
    {
        return MinimumBeautifulSubstringsRecursive(0, s);
    }

    private static int MinimumBeautifulSubstringsRecursive(int index, string s)
    {
        if (index == s.Length)
            return 0;

        var min = int.MaxValue;

        for (var i = index + 1; i <= s.Length; i++)
        {
            if (s[index] != '1')
                continue;

            var sub = s[index..i];
            var num = Convert.ToInt32(sub, 2);

            if (num <= 0 || 15625 % num != 0)
                continue;

            var k = MinimumBeautifulSubstringsRecursive(i, s);

            if (k >= 0)
                min = Math.Min(min, 1 + k);
        }

        return min == int.MaxValue ? -1 : min;
    }
}
