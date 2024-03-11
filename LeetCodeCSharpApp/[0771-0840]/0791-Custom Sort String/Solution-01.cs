namespace LeetCodeCSharpApp.CustomSortString01;

/// <summary>
///   Custom Comparator
///
///   Time Complexity: O(N * log(N))
///   Space Complexity: O(N)
/// </summary>
public class Solution
{
    public string CustomSortString(string order, string s)
    {
        char[] result = s.ToCharArray();

        Array.Sort(result, (c1, c2) => order.IndexOf(c1) - order.IndexOf(c2));

        return new string(result);
    }
}
