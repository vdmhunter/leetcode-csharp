namespace LeetCodeCSharpApp.SimplifyPath01;

public class Solution
{
    public string SimplifyPath(string path)
    {
        var stack = new Stack<string>();

        foreach (var e in path.Split('/'))
            if (stack.Count > 0 && e == "..")
                stack.Pop();
            else if (e != "." && e != "" && e != "..")
                stack.Push(e);

        var result = string.Join('/', stack.Reverse());

        return "/" + result;
    }
}
