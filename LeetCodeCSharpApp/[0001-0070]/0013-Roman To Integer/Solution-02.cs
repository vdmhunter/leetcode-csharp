namespace LeetCodeCSharpApp.RomanToInteger02;

public class Solution
{
    public int RomanToInt(string str)
    {
        var result = 0;

        for (var i = 0; i < str.Length; i++)
        {
            var s1 = Value(str[i]);

            if (i + 1 < str.Length)
            {
                var s2 = Value(str[i + 1]);

                if (s1 >= s2)
                    result += s1;
                else
                {
                    result = result + s2 - s1;
                    i++;
                }
            }
            else
            {
                result += s1;
                i++;
            }
        }

        return result;
    }

    private static int Value(char r)
    {
        return r switch
        {
            'I' => 1,
            'V' => 5,
            'X' => 10,
            'L' => 50,
            'C' => 100,
            'D' => 500,
            'M' => 1000,
            _ => -1
        };
    }
}
