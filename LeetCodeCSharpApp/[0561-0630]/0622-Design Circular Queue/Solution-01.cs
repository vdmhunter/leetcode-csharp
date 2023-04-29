// ReSharper disable MemberCanBePrivate.Global

namespace LeetCodeCSharpApp.DesignCircularQueue01;

public class MyCircularQueue
{
    private readonly int[] _q;
    private int _front;
    private int _rear = -1;
    private int _count;

    public MyCircularQueue(int k)
    {
        _q = new int[k];
    }

    public bool EnQueue(int value)
    {
        if (IsFull())
            return false;

        _count++;
        _rear = (_rear + 1) % _q.Length;
        _q[_rear] = value;

        return true;
    }

    public bool DeQueue()
    {
        if (IsEmpty())
            return false;

        _count--;
        _front = (_front + 1) % _q.Length;

        return true;
    }

    public int Front() => IsEmpty() ? -1 : _q[_front];

    public int Rear() => IsEmpty() ? -1 : _q[_rear];

    public bool IsEmpty() => _count == 0;

    public bool IsFull() => _count == _q.Length;
}
