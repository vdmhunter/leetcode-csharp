using System.Text;

namespace LeetCodeCSharpApp.IntegerToRoman02;

public class Solution
{
    public string IntToRoman(int num)
    {
        var result = new StringBuilder();

        (int Value, string Roman)[] numToRoman =
        {
            (1000, "M"),
            (900, "CM"),
            (500, "D"),
            (400, "CD"),
            (100, "C"),
            (90, "XC"),
            (50, "L"),
            (40, "XL"),
            (10, "X"),
            (9, "IX"),
            (5, "V"),
            (4, "IV"),
            (1, "I")
        };

        var i = 0;

        while (num > 0)
        {
            while (num >= numToRoman[i].Value)
            {
                num -= numToRoman[i].Value;
                result.Append(numToRoman[i].Roman);
            }

            i++;
        }

        return result.ToString();
    }
}
