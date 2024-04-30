namespace LeetCodeCSharpApp.NumberOfWonderfulSubstrings01;

public class Solution
{
    public long WonderfulSubstrings(string word)
    {
        var result = 0L;
        var mask = 0;
        var cnt = new long[1024];
        cnt[0] = 1;

        foreach (char ch in word)
        {
            mask ^= 1 << (ch - 'a');
            result += cnt[mask];

            for (var n = 0; n < 10; ++n)
                result += cnt[mask ^ (1 << n)];

            cnt[mask]++;
        }

        return result;
    }
}
