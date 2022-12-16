namespace LeetCodeCSharpApp.ImplementQueueUsingStacks03;

public class MyQueue
{
    private readonly Stack<int> _s1 = new();
    private readonly Stack<int> _s2 = new();

    public void Push(int x) => _s1.Push(x);

    public int Pop()
    {
        if (_s2.Count != 0)
            return _s2.Pop();

        while (_s1.Count > 0)
            _s2.Push(_s1.Pop());

        return _s2.Pop();
    }

    public int Peek()
    {
        if (_s2.Count != 0)
            return _s2.Peek();

        while (_s1.Count > 0)
            _s2.Push(_s1.Pop());

        return _s2.Peek();
    }

    public bool Empty() => Count == 0;

    private int Count => _s1.Count + _s2.Count;
}
