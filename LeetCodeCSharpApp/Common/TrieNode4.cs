namespace LeetCodeCSharpApp.Common;

public class TrieNode4
{
    private readonly TrieNode4[] _children;

    public int Count;

    public TrieNode4()
    {
        _children = new TrieNode4[26];
        Count = 0;
    }

    public TrieNode4 Get(char c)
    {
        if (_children[c - 'a'] != null!)
            return _children[c - 'a'];

        _children[c - 'a'] = new TrieNode4();
        Count++;

        return _children[c - 'a'];
    }
}
