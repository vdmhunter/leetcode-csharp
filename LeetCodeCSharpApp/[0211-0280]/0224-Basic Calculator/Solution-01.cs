namespace LeetCodeCSharpApp.BasicCalculator01;

public class Solution
{
    public int Calculate(string s)
    {
        var stack = new Stack<int>();
        var result = 0;
        var number = 0;
        var sign = 1;

        foreach (var c in s)
        {
            if (char.IsDigit(c))
                number = 10 * number + (c - '0');
            else switch (c)
            {
                case '+':
                    result += sign * number;
                    number = 0;
                    sign = 1;
                    break;
                case '-':
                    result += sign * number;
                    number = 0;
                    sign = -1;
                    break;
                case '(':
                    stack.Push(result);
                    stack.Push(sign);
                    sign = 1;
                    result = 0;
                    break;
                case ')':
                    result += sign * number;
                    number = 0;
                    result *= stack.Pop(); //stack.Pop() is the sign before the parenthesis
                    result += stack.Pop(); //stack.Pop() now is the result calculated before the parenthesis
                    break;
            }
        }

        return number != 0 ? result + sign * number : result;
    }
}
