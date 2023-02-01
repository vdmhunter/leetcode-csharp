namespace LeetCodeCSharpApp.GreatestCommonDivisorOfStrings02;

public class Solution
{
    public string GcdOfStrings(string str1, string str2)
    {
        while (true)
        {
            if (str1.Length < str2.Length)
            {
                (str1, str2) = (str2, str1);

                continue;
            }

            if (!str1.StartsWith(str2))
                return "";

            if (str2.Length == 0)
                return str1;

            str1 = str1[str2.Length..];
        }
    }
}
