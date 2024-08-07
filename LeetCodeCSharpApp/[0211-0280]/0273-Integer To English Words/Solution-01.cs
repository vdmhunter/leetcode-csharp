using System.Text;

namespace LeetCodeCSharpApp.IntegerToEnglishWords01;

public class Solution
{
    private readonly string[] _belowTwenty =
    [
        "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine",
        "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen",
        "Seventeen", "Eighteen", "Nineteen"
    ];

    private readonly string[] _tens =
    [
        "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"
    ];

    private readonly string[] _thousands =
    [
        "", "Thousand", "Million", "Billion"
    ];

    public string NumberToWords(int num)
    {
        if (num == 0)
            return "Zero";

        var i = 0;
        var words = new StringBuilder();

        while (num > 0)
        {
            if (num % 1000 != 0)
            {
                var part = new StringBuilder();
                Helper(num % 1000, part);
                words.Insert(0, part.Append(_thousands[i]).Append(' '));
            }

            num /= 1000;
            i++;
        }

        return words.ToString().Trim();
    }

    private void Helper(int num, StringBuilder words)
    {
        while (true)
        {
            switch (num)
            {
                case 0:
                    return;
                case < 20:
                    words.Append(_belowTwenty[num]).Append(' ');
                    break;
                case < 100:
                    words.Append(_tens[num / 10]).Append(' ');
                    num %= 10;
                    continue;
                default:
                    words.Append(_belowTwenty[num / 100]).Append(" Hundred ");
                    num %= 100;
                    continue;
            }

            break;
        }
    }
}
