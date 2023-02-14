namespace LeetCodeCSharpApp.AddBinary01;

public class Solution
{
    public string AddBinary(string a, string b)
    {
        var carry = 0;
        var stack = new Stack<char>();

        for (var i = 1; i <= Math.Max(a.Length, b.Length); i++)
        {
            var opA = i <= a.Length ? a[^i] - '0' : 0;
            var opB = i <= b.Length ? b[^i] - '0' : 0;
            var sum = opA + opB + carry;
            stack.Push((char)(sum % 2 + '0'));
            carry = sum / 2;
        }

        if (carry == 1)
            stack.Push((char)(carry + '0'));
        
        return new string(stack.ToArray());
    }
}
