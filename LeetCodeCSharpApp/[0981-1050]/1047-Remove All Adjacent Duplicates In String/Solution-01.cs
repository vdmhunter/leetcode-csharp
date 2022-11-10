namespace LeetCodeCSharpApp.RemoveAllAdjacentDuplicatesInString01;

public class Solution
{
    public string RemoveDuplicates(string s)
    {
        var stack = new Stack<char>();

        foreach (var c in s)
            if (stack.Any() && stack.Peek() == c)
                stack.Pop();
            else
                stack.Push(c);

        var arr = stack.ToArray();

        Array.Reverse(arr);

        return new string(arr);
    }
}
