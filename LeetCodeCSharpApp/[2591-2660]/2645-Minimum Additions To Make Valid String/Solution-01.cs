namespace LeetCodeCSharpApp.MinimumAdditionsToMakeValidString01;

public class Solution
{
    public int AddMinimum(string word)
    {
        int cnt = 0, pos = 0;

        foreach (var cur in word.Select(ch => ch - 'a'))
        {
            if (cur < pos)
                ++cnt;

            pos = cur + 1;
        }

        cnt += pos > 0 ? 1 : 0;

        return cnt * 3 - word.Length;
    }
}
