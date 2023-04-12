namespace LeetCodeCSharpApp.SimplifyPath01;

public class Solution
{
    public string SimplifyPath(string path)
    {
        var stack = new Stack<string>();

        foreach (var elem in path.Split('/'))
            if (stack.Count > 0 && elem == "..")
                stack.Pop();
            else if (elem != "." && elem != "" && elem != "..")
                stack.Push(elem);

        var result = string.Join('/', stack.Reverse());

        return "/" + result;
    }
}
