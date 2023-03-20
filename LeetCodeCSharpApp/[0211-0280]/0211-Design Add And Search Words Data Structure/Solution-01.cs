namespace LeetCodeCSharpApp.DesignAddAndSearchWordsDataStructure01;

public class WordDictionary
{
    private readonly TrieNode _root;

    public class TrieNode
    {
        public bool IsWordEnd;
        public readonly Dictionary<char, TrieNode> Nodes;

        public TrieNode()
        {
            IsWordEnd = false;
            Nodes = new Dictionary<char, TrieNode>();
        }
    }

    public WordDictionary()
    {
        _root = new TrieNode();
    }

    public void AddWord(string word)
    {
        var temp = _root;

        foreach (var ch in word)
            if (temp.Nodes.ContainsKey(ch))
                temp = temp.Nodes[ch];
            else
            {
                var newNode = new TrieNode();
                temp.Nodes.Add(ch, newNode);
                temp = newNode;
            }

        temp.IsWordEnd = true;
    }

    public bool Search(string word)
    {
        return SearchTrie(_root, word, 0);
    }

    private bool SearchTrie(TrieNode root, string word, int index)
    {
        var temp = root;

        if (index == word.Length)
            return temp.IsWordEnd;

        if (word[index] == '.')
            return temp.Nodes.Any(node => SearchTrie(node.Value, word, index + 1));

        if (!temp.Nodes.ContainsKey(word[index]))
            return false;

        temp = temp.Nodes[word[index]];

        return SearchTrie(temp, word, index + 1);
    }
}
