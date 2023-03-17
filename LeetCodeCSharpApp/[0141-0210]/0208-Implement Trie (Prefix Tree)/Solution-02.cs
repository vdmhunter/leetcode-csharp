namespace LeetCodeCSharpApp.ImplementTriePrefixTree02;

public class Trie
{
    private readonly HashSet<string> _strSet;

    public Trie() => _strSet = new HashSet<string>();

    public void Insert(string word)
    {
        if (_strSet.Contains(word) == false)
            _strSet.Add(word);
    }

    public bool Search(string word) => _strSet.Contains(word);

    public bool StartsWith(string prefix) =>
        _strSet.Contains(prefix) || _strSet.Any(element => element.StartsWith(prefix));
}
