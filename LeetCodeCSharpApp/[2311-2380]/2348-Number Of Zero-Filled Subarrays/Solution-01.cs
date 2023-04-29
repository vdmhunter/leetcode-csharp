namespace LeetCodeCSharpApp.NumberOfZeroFilledSubarrays01;

public class Solution
{
    public long ZeroFilledSubarray(int[] nums)
    {
        var result = 0L;
        var countOfZeros = 0L;

        foreach (var n in nums)
        {
            if (n == 0)
            {
                countOfZeros++;
                continue;
            }

            if (countOfZeros != 0)
                result += (1 + countOfZeros) * countOfZeros / 2;

            countOfZeros = 0;
        }

        result += (1 + countOfZeros) * countOfZeros / 2;

        return result;
    }
}
