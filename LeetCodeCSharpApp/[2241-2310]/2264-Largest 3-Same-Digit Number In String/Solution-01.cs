namespace LeetCodeCSharpApp.Largest3SameDigitNumberInString01;

public class Solution
{
    public string LargestGoodInteger(string num)
    {
        var result = "";

        for (var i = 2; i < num.Length; i++)
        {
            if (num[i] != num[i - 1] || num[i] != num[i - 2])
                continue;

            var currentStr = num.Substring(i - 2, 3);

            if (string.CompareOrdinal(currentStr, result) > 0)
                result = currentStr;
        }

        return result;
    }
}
