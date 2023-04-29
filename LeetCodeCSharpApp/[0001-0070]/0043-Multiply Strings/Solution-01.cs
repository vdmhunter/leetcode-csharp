using System.Text;

namespace LeetCodeCSharpApp.MultiplyStrings01;

public class Solution
{
    public string Multiply(string num1, string num2)
    {
        int m = num1.Length, n = num2.Length;
        var pos = new int[m + n];

        for (var i = m - 1; i >= 0; i--)
            for (var j = n - 1; j >= 0; j--)
            {
                var mul = (num1[i] - '0') * (num2[j] - '0');
                var p1 = i + j;
                var p2 = i + j + 1;
                var sum = mul + pos[p2];

                pos[p1] += sum / 10;
                pos[p2] = sum % 10;
            }

        var sb = new StringBuilder();

        foreach (var p in pos)
            if (!(sb.Length == 0 && p == 0))
                sb.Append(p);

        return sb.Length == 0 ? "0" : sb.ToString();
    }
}
