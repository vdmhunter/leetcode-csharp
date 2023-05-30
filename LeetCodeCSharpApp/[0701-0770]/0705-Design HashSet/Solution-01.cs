using System.Collections;

namespace LeetCodeCSharpApp.DesignHashSet01;

public class MyHashSet
{
    private readonly BitArray _arr;

    public MyHashSet()
    {
        _arr = new BitArray(1000001);
    }

    public void Add(int key)
    {
        _arr[key] = true;
    }

    public void Remove(int key)
    {
        _arr[key] = false;
    }

    public bool Contains(int key)
    {
        return _arr[key];
    }
}
