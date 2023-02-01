namespace LeetCodeCSharpApp.GreatestCommonDivisorOfStrings01;

public class Solution
{
    public string GcdOfStrings(string str1, string str2)
    {
        if (str1.Length < str2.Length)
            return GcdOfStrings(str2, str1);

        if (!str1.StartsWith(str2))
            return "";

        return str2.Length == 0 ? str1 : GcdOfStrings(str1[str2.Length..], str2);
    }
}
