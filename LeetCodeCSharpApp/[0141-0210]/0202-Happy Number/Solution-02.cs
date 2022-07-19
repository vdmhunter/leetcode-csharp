namespace LeetCodeCSharpApp.HappyNumber02;

/// <summary>
/// Hardcoding the Only Cycle
/// </summary>
public class Solution
{
    private static readonly HashSet<int> CycleMembers = new() { 4, 16, 37, 58, 89, 145, 42, 20 };

    public bool IsHappy(int n)
    {
        while (n != 1 && !CycleMembers.Contains(n))
            n = n.ToString().ToCharArray().Select(c => (c - '0') * (c - '0')).Sum();

        return n == 1;
    }
}
