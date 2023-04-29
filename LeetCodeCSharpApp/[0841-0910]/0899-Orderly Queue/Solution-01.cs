namespace LeetCodeCSharpApp.OrderlyQueue01;

public class Solution
{
    public string OrderlyQueue(string s, int k)
    {
        if (k > 1)
        {
            var charArray = s.ToCharArray();
            Array.Sort(charArray);

            return new string(charArray);
        }

        var result = s;

        for (var i = 1; i < s.Length; i++)
        {
            var tmp = string.Concat(s.AsSpan(i), s.AsSpan(0, i));

            if (string.Compare(result, tmp, StringComparison.Ordinal) > 0)
                result = tmp;
        }

        return result;
    }
}
