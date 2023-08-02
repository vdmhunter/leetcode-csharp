namespace LeetCodeCSharpApp.Combinations01;

public class Solution
{
    public IList<IList<int>> Combine(int n, int k)
    {
        if (k == n || k == 0)
            return new List<IList<int>> { Enumerable.Range(1, k).ToList() };

        var result = Combine(n - 1, k - 1);
        result.ToList().ForEach(e => e.Add(n));
        result = result.Concat(Combine(n - 1, k)).ToList();

        return result;
    }
}
