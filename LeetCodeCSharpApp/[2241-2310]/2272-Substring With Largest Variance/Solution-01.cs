namespace LeetCodeCSharpApp.SubstringWithLargestVariance01;

public class Solution
{
    public int LargestVariance(string s)
    {
        var unique = new HashSet<char>(s);

        return unique.Aggregate(0,
            (curr2, a) => unique.Aggregate(curr2, (curr1, b) => Result(s, a, b, curr1)));
    }

    private static int Result(string s, char a, char b, int result)
    {
        int var = 0, hasB = 0, firstB = 0;

        foreach (var ch in s)
        {
            var += ch == a ? 1 : 0;

            if (ch == b)
            {
                hasB = 1;

                if (firstB != 0 && var >= 0)
                {
                    firstB = 0;
                }
                else if (--var < 0)
                {
                    firstB = 1;
                    var = -1;
                }
            }

            result = Math.Max(result, hasB != 0 ? var : 0);
        }

        return result;
    }
}
