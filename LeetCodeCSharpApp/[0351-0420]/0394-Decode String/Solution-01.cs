using System.Text;

namespace LeetCodeCSharpApp.DecodeString01;

public class Solution
{
    private int _pos;

    public string DecodeString(string s)
    {
        var res = new StringBuilder();

        for (var num = 0; _pos < s.Length; ++_pos)
        {
            var c = s[_pos];

            if (char.IsDigit(c))
                num = num * 10 + (c - '0');
            else
                switch (c)
                {
                    case '[':
                    {
                        ++_pos;

                        var str = DecodeString(s);

                        for (var j = 0; j < num; ++j)
                            res.Append(str);

                        num = 0;
                        break;
                    }
                    case ']':
                        return res.ToString();
                    default:
                        res.Append(c);
                        break;
                }
        }

        return res.ToString();
    }
}
