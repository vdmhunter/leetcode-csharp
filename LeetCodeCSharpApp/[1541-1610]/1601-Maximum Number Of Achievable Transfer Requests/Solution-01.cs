namespace LeetCodeCSharpApp.MaximumNumberOfAchievableTransferRequests01;

public class Solution
{
    public int MaximumRequests(int n, int[][] requests)
    {
        var nr = requests.Length;
        var result = 0;

        for (var i = 0; i < 1 << nr; i++)
            result = Math.Max(result, Test(i));

        int Test(int mask)
        {
            var outDegrees = new int[n];
            var inDegrees = new int[n];

            for (var k = 0; k < nr; k++)
                if ((1 << k & mask) != 0)
                {
                    outDegrees[requests[k][0]] += 1;
                    inDegrees[requests[k][1]] += 1;
                }

            return outDegrees.SequenceEqual(inDegrees) ? outDegrees.Sum() : 0;
        }

        return result;
    }
}
