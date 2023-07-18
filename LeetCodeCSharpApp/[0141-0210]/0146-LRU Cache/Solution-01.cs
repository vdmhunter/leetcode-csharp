namespace LeetCodeCSharpApp.LRUCache01;

public class LRUCache
{
    private readonly Dictionary<int, LinkedListNode<int>> _hashes;
    private readonly LinkedList<int> _list;
    private readonly int _capacity;

    public LRUCache(int capacity)
    {
        _hashes = new Dictionary<int, LinkedListNode<int>>(capacity);
        _list = new LinkedList<int>();
        _capacity = capacity;
    }

    public int Get(int key)
    {
        if (!_hashes.ContainsKey(key))
            return -1;

        var node = _hashes[key];

        if (node.List == null)
        {
            _hashes.Remove(key);

            return -1;
        }

        _list.Remove(node);
        _list.AddFirst(node);

        return node.Value;
    }

    public void Put(int key, int value)
    {
        if (_hashes.TryGetValue(key, out var node))
        {
            if (node.List != null)
            {
                node.Value = value;
                _list.Remove(node);
                _list.AddFirst(node);

                return;
            }

            _hashes.Remove(key);
        }

        if (_list.Count == _capacity)
            _list.RemoveLast();

        var newNode = _list.AddFirst(value);
        _hashes.Add(key, newNode);
    }
}
