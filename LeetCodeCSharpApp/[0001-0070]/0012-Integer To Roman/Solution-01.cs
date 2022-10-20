// ReSharper disable StringLiteralTypo

namespace LeetCodeCSharpApp.IntegerToRoman01;

public class Solution
{
    public string IntToRoman(int num)
    {
        var m = new[] { "", "M", "MM", "MMM" };
        var c = new[] { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
        var x = new[] { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        var i = new[] { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

        return m[num / 1000] + c[num % 1000 / 100] + x[num % 100 / 10] + i[num % 10];
    }
}
