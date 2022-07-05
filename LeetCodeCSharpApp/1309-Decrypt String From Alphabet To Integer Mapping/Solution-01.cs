using System.Text;

namespace LeetCodeCSharpApp.DecryptStringFromAlphabetToIntegerMapping01;

public class Solution
{
    public string FreqAlphabets(string s)
    {
        var output = new StringBuilder();

        for (var i = s.Length - 1; i >= 0; i--)
            if (s[i] == '#')
            {
                output.Append((char)('a' + (s[i - 1] - '0') + 10 * (s[i - 2] - '0') - 1));

                i -= 2;
            }
            else
                output.Append((char)('a' + (s[i] - '0') - 1));

        return new string(output.ToString().Reverse().ToArray());
        //return re.sub(r'\d{2}#|\d', lambda x: chr(int(x.group()[:2])+96), s)
    }
}
