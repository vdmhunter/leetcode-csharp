namespace LeetCodeCSharpApp.ConcatenatedWords01;

public class Solution
{
    public IList<string> FindAllConcatenatedWordsInADict(string[] words)
    {
        HashSet<string> ws = new(words);

        return words.Where(w => IsConcatenated(w)).ToList();

        bool IsConcatenated(string w, int count = 0)
        {
            return (w.Length == 0 && count > 1)
                   || Enumerable
                       .Range(1, w.Length)
                       .Any(i => ws.Contains(w[..i]) && IsConcatenated(w[i..], count + 1));
        }
    }
}
