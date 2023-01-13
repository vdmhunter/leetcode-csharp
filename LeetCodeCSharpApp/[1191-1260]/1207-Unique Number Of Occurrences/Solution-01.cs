namespace LeetCodeCSharpApp.UniqueNumberOfOccurrences01;

public class Solution
{
    public bool UniqueOccurrences(int[] arr)
    {
        return arr.GroupBy(a => a).GroupBy(a => a.Count()).All(a => a.Count() == 1);
    }
}
