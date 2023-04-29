namespace LeetCodeCSharpApp.FlipStringToMonotoneIncreasing01;

public class Solution
{
    public int MinFlipsMonoIncr(string s)
    {
        var countOnes = 0;
        var countFlip = 0;

        foreach (var c in s)
        {
            if (c == '1')
                countOnes++;
            else
                countFlip++;

            countFlip = Math.Min(countFlip, countOnes);
        }

        return countFlip;
    }
}
