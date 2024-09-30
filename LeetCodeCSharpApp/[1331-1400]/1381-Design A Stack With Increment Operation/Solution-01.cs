namespace LeetCodeCSharpApp.DesignAStackWithIncrementOperation01;

public class CustomStack(int maxSize)
{
    private readonly int[] _stack = new int[maxSize];
    private int _top = -1;
    private int _size;

    public void Push(int x)
    {
        if (_size == maxSize)
            return;

        _stack[++_top] = x;
        _size++;
    }

    public int Pop()
    {
        if (_size == 0)
            return -1;

        _size--;

        return _stack[_top--];
    }

    public void Increment(int k, int val)
    {
        if (_top == -1)
            return;

        if (k > _size)
        {
            for (var i = 0; i < _size; i++)
                _stack[i] += val;
        }
        else
        {
            for (var i = 0; i < k; i++)
                _stack[i] += val;
        }
    }
}
