namespace LeetCodeCSharpApp.MinimumOperationsToMakeASpecialNumber01;

public class Solution
{
    public int MinimumOperations(string num)
    {
        var n = num.Length;

        var lastZeroIndex = num.LastIndexOf('0');
        var lastFiveIndex = num.LastIndexOf('5');

        var operationsFromZero = lastZeroIndex >= 0 ? Math.Min(n - 1, Check(num, lastZeroIndex)) : n;
        var operationsFromFive = Check(num, lastFiveIndex);

        return Math.Min(operationsFromZero, operationsFromFive);
    }

    private static int Check(string num, int i)
    {
        for (var j = i - 1; j >= 0; j--)
        {
            var t = num[i] - '0' + (num[j] - '0') * 10;

            if (t % 25 == 0)
                return num.Length - j - 2;
        }

        return num.Length;
    }
}