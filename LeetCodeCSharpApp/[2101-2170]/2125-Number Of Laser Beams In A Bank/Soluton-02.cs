namespace LeetCodeCSharpApp.NumberOfLaserBeamsInABank02;

public class Solution
{
    public int NumberOfBeams(string[] bank)
    {
        var result = bank.Aggregate((Prev: 0, Result: 0), (acc, r) =>
        {
            var cur = r.Count(c => c == '1');

            return cur > 0
                ? (cur, acc.Result + acc.Prev * cur)
                : acc;
        });

        return result.Result;
    }
}
