namespace LeetCodeCSharpApp.RomanToInteger04;

public class Solution
{
    public int RomanToInt(string s)
    {
        var result = 0;
        var num = 0;

        for (var i = s.Length - 1; i >= 0; i--)
        {
            num = s[i] switch
            {
                'I' => 1,
                'V' => 5,
                'X' => 10,
                'L' => 50,
                'C' => 100,
                'D' => 500,
                'M' => 1000,
                _ => num
            };

            if (4 * num < result)
                result -= num;
            else
                result += num;
        }

        return result;
    }
}
