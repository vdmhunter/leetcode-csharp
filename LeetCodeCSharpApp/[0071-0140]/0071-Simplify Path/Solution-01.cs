namespace LeetCodeCSharpApp.SimplifyPath01;

public class Solution
{
    public string SimplifyPath(string path)
    {
        var stack = new Stack<string>();

        foreach (var e in path.Split('/'))
            if (stack.Count > 0 && e == "..")
                stack.Pop();
            else if (e is not ("." or "" or ".."))
                stack.Push(e);

        return $"/{string.Join('/', stack.Reverse())}";
    }
}
