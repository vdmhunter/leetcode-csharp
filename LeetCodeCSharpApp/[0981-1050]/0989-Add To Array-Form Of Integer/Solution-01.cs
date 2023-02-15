using System.Numerics;

namespace LeetCodeCSharpApp.AddToArrayFormOfInteger01;

public class Solution
{
    public IList<int> AddToArrayForm(int[] num, int k)
    {
        var n = BigInteger.Parse(string.Join("", num));

        return (n + k).ToString().Select(c => int.Parse(c.ToString())).ToList();
    }
}
