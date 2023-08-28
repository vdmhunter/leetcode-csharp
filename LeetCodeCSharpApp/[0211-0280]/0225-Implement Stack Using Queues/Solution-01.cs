namespace LeetCodeCSharpApp.ImplementStackUsingQueues01;

public class MyStack
{
    private readonly Queue<int> _q;

    public MyStack()
    {
        _q = new Queue<int>();
    }

    public void Push(int x)
    {
        _q.Enqueue(x);

        for (var i = 0; i < _q.Count - 1; i++)
            _q.Enqueue(_q.Dequeue());
    }

    public int Pop()
    {
        return _q.Dequeue();
    }

    public int Top()
    {
        return _q.Peek();
    }

    public bool Empty()
    {
        return _q.Count == 0;
    }
}
