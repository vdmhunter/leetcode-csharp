namespace LeetCodeCSharpApp.ImplementTriePrefixTree01;

public class Trie
{
    private readonly TrieNode _head;

    public Trie() => _head = new TrieNode();

    public void Insert(string word)
    {
        var current = word.Aggregate(_head, (curr, c) => curr[c] ??= new TrieNode());
        current.Tail = true;
    }

    public bool Search(string word)
    {
        var node = ToTail(word);

        return node?.Tail ?? false;
    }

    public bool StartsWith(string prefix) => ToTail(prefix) != null;

    private TrieNode ToTail(string prefix)
    {
        var current = _head;

        foreach (var c in prefix)
        {
            current = current[c];

            if (current == null)
                return current!;
        }

        return current;
    }

    private class TrieNode
    {
        private readonly TrieNode[] _suffixes = new TrieNode[26];

        internal TrieNode this[char c]
        {
            get => _suffixes[c - 'a'];
            set => _suffixes[c - 'a'] = value;
        }

        internal bool Tail { get; set; }
    }
}
