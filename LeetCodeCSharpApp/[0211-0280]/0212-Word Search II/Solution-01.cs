namespace LeetCodeCSharpApp.WordSearchII01;

public class Solution
{
    public IList<string> FindWords(char[][] board, string[] words)
    {
        var result = new List<string>();
        var root = BuildTrie(words);

        for (var i = 0; i < board.Length; i++)
            for (var j = 0; j < board[0].Length; j++)
                Dfs(board, i, j, root, result);

        return result;
    }

    private void Dfs(char[][] b, int i, int j, TrieNode p, List<string> r)
    {
        var c = b[i][j];

        if (c == '#' || p.Next[c - 'a'] == null)
            return;

        p = p.Next[c - 'a'];

        if (p.Word != null)
        {
            r.Add(p.Word);
            p.Word = null!;
        }

        b[i][j] = '#';

        if (i > 0)
            Dfs(b, i - 1, j, p, r);

        if (j > 0)
            Dfs(b, i, j - 1, p, r);

        if (i < b.Length - 1)
            Dfs(b, i + 1, j, p, r);

        if (j < b[0].Length - 1)
            Dfs(b, i, j + 1, p, r);

        b[i][j] = c;
    }

    private TrieNode BuildTrie(string[] words)
    {
        var root = new TrieNode();

        foreach (var w in words)
        {
            var p = root;

            foreach (var c in w.ToCharArray())
            {
                var i = c - 'a';
                p.Next[i] ??= new TrieNode();
                p = p.Next[i];
            }

            p.Word = w;
        }

        return root;
    }

    private class TrieNode
    {
        public readonly TrieNode[] Next = new TrieNode[26];
        public string Word = null!;
    }
}
