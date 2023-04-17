namespace LeetCodeCSharpApp.KidsWithTheGreatestNumberOfCandies01;

public class Solution
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        return candies.Select(c => c + extraCandies >= candies.Max()).ToArray();
    }
}
