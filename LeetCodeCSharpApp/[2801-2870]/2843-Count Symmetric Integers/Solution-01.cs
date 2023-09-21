namespace LeetCodeCSharpApp.CountSymmetricIntegers01;

public class Solution
{
    public int CountSymmetricIntegers(int low, int high)
    {
        var result = 0;

        for (var i = Math.Max(low, 10); i <= high; i++)
        {
            var s = i.ToString();

            if (s.Length % 2 != 0)
                continue;

            var halfLength = s.Length / 2;
            var sumFirstHalf = 0;
            var sumSecondHalf = 0;

            for (var j = 0; j < halfLength; j++)
            {
                sumFirstHalf += s[j] - '0';
                sumSecondHalf += s[j + halfLength] - '0';
            }

            if (sumFirstHalf == sumSecondHalf)
                result++;
        }

        return result;
    }
}
