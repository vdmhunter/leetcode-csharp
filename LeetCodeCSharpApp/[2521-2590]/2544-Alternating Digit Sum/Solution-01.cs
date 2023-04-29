namespace LeetCodeCSharpAppAlternatingDigitSum01;

public class Solution
{
    public int AlternateDigitSum(int n)
    {
        var nString = n.ToString();
        var totalSum = int.Parse(nString[0].ToString());

        for (var i = 1; i < nString.Length; i++)
            if (i % 2 == 0)
                totalSum += int.Parse(nString[i].ToString());
            else
                totalSum -= int.Parse(nString[i].ToString());

        return totalSum;
    }
}
