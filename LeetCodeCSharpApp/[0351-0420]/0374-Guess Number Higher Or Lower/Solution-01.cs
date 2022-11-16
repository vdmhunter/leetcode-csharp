using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.GuessNumberHigherOrLower01;

public class Solution : GuessGame
{
    public int GuessNumber(int n)
    {
        int i = 1, j = n;

        while (i <= j)
        {
            var mid = i + (j - i) / 2;

            if (guess(mid) > 0)
                i = mid + 1;
            else if (guess(mid) < 0)
                j = mid - 1;
            else
                return mid;
        }

        return -1;
    }
}
