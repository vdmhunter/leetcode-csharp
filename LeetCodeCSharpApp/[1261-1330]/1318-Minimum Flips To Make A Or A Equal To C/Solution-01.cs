namespace LeetCodeCSharpApp.MinimumFlipsToMakeAOrAEqualToC01;

public class Solution
{
    public int MinFlips(int a, int b, int c)
    {
        var result = 0;
        var ab = a | b;
        var equal = ab ^ c;

        for (var i = 0; i < 31; ++i)
        {
            var mask = 1 << i;

            if ((equal & mask) > 0) // ith bits of a | b and c are not same, need at least 1 flip.
                result += (a & mask) == (b & mask) && (c & mask) == 0
                    ? 2
                    : 1; // ith bits of a and b are both 1 and that of c is 0?
        }

        return result;
    }
}
