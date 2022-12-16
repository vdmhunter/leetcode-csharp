namespace LeetCodeCSharpApp.ImplementQueueUsingStacks02;

public class MyQueue
{
    private readonly Stack<int> _s1 = new();
    private readonly Stack<int> _s2 = new();

    public void Push(int x)
    {
        if (_s2.Count > 0)
            Pump(_s2, _s1);

        _s1.Push(x);
    }

    public int Pop() => GetFirst(true);

    public int Peek() => GetFirst(false);

    public bool Empty() => _s1.Count + _s2.Count == 0;

    private int GetFirst(bool isPop)
    {
        if (_s1.Count > 0)
            Pump(_s1, _s2);

        return isPop ? _s2.Pop() : _s2.Peek();
    }

    private static void Pump(Stack<int> from, Stack<int> to)
    {
        while (from.Count > 0)
            to.Push(from.Pop());
    }
}
