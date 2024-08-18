namespace LeetCodeCSharpApp.UglyNumberII01;

public class Solution
{
    public int NthUglyNumber(int n)
    {
        var uglyNumbersSet = new SortedSet<long> { 1L };
        var currentUgly = 1L;

        for (var i = 0; i < n; i++)
        {
            currentUgly = uglyNumbersSet.Min;
            uglyNumbersSet.Remove(currentUgly);

            uglyNumbersSet.Add(currentUgly * 2);
            uglyNumbersSet.Add(currentUgly * 3);
            uglyNumbersSet.Add(currentUgly * 5);
        }

        return (int)currentUgly;
    }
}
