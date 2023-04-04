namespace LeetCodeCSharpApp.OptimalPartitionOfString02;

public class Solution
{
    public int PartitionString(string s)
    {
        var result = 1;
        var map = 0;
        const int mask = (1 << 26) - 1;

        for (var i = 0; i < s.Length; i++)
        {
            var bit = 1 << (s[i] - 'a');

            if ((map & bit) != 0)
            {
                result++;
                map = 0;
            }

            map = (map ^ bit) & mask;
        }

        return result;
    }
}
