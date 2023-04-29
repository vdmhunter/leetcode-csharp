// ReSharper disable InconsistentNaming

namespace LeetCodeCSharpApp.EvaluateReversePolishNotation01;

public class Solution
{
    public int EvalRPN(string[] tokens)
    {
        var stack = new Stack<int>();

        foreach (var token in tokens)
            if (token is "+" or "-" or "*" or "/")
            {
                var right = stack.Pop();
                var left = stack.Pop();

                var result = token switch
                {
                    "+" => left + right,
                    "-" => left - right,
                    "*" => left * right,
                    "/" => left / right,
                    _ => throw new ArgumentOutOfRangeException(nameof(token))
                };

                stack.Push(result);
            }
            else
                stack.Push(int.Parse(token));

        return stack.Pop();
    }
}
