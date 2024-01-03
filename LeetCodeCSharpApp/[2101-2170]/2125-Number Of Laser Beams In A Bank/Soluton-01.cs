namespace LeetCodeCSharpApp.NumberOfLaserBeamsInABank01;

public class Solution
{
    public int NumberOfBeams(string[] bank)
    {
        var prev = 0;
        var result = 0;

        foreach (var r in bank)
        {
            var cur = r.Count(c => c == '1');

            if (cur <= 0)
                continue;

            result += prev * cur;
            prev = cur;
        }

        return result;
    }
}
