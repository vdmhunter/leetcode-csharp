namespace LeetCodeCSharpApp.SumMultiples01;

public class Solution
{
    public int SumOfMultiples(int n)
    {
        return Enumerable.Range(1, n).Where(i => i % 3 == 0 || i % 5 == 0 || i % 7 == 0).Sum();
    }
}
