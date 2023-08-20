namespace LeetCodeCSharpApp.NumberOfBeautifulIntegersInTheRange01;

public class Solution
{
    public int NumberOfBeautifulIntegers(int low, int high, int k)
    {
        low = ((low - 1) / k + 1) * k;
        var count = 0;

        while (low <= high)
        {
            count += Check(low);
            low += k;

            if (low >= 100_000_000)
                return count;
        }

        return count;
    }

    private static int Check(int low)
    {
        var even = 0;
        var odd = 0;

        while (low > 0)
        {
            if (low % 2 == 0)
                even++;
            else
                odd++;

            low /= 10;
        }

        return even == odd ? 1 : 0;
    }
}
