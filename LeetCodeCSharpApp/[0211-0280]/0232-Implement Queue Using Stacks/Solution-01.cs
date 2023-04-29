namespace LeetCodeCSharpApp.ImplementQueueUsingStacks01;

public class MyQueue
{
    private readonly Stack<int> _s1 = new();
    private readonly Stack<int> _s2 = new();

    public void Push(int x)
    {
        while (_s1.Count != 0)
            _s2.Push(_s1.Pop());

        _s1.Push(x);

        while (_s2.Count != 0)
            _s1.Push(_s2.Pop());
    }

    public int Pop()
    {
        return _s1.Pop();
    }

    public int Peek()
    {
        return _s1.Peek();
    }

    public bool Empty()
    {
        return _s1.Count == 0;
    }
}
