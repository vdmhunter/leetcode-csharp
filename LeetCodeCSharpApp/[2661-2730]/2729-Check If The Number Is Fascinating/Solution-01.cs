namespace LeetCodeCSharpApp.CheckIfTheNumberIsFascinating01;

public class Solution
{
    public bool IsFascinating(int n)
    {
        var concatenatedNumber = n + (2 * n).ToString() + 3 * n;

        if (concatenatedNumber.Contains('0'))
            return false;

        var digitCount = new int[10];

        foreach (var c in concatenatedNumber)
            digitCount[(int)char.GetNumericValue(c)]++;

        for (var i = 1; i <= 9; i++)
            if (digitCount[i] != 1)
                return false;

        return true;
    }
}
