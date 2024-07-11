namespace LeetCodeCSharpApp.ReverseSubstringsBetweenEachPairOfParentheses01;

public class Solution
{
    public string ReverseParentheses(string s)
    {
        char[] result = s.ToCharArray();
        var stack = new Stack<int>();

        for (var i = 0; i < s.Length; i++)
        {
            switch (s[i])
            {
                case '(':
                    stack.Push(i);

                    break;
                case ')':
                    for (int l = stack.Pop() + 1, r = i - 1; l < r; l++, r--)
                        (result[l], result[r]) = (result[r], result[l]);

                    break;
            }
        }

        return new string(result.Where(ch => ch != ')' && ch != '(').ToArray());
    }
}
