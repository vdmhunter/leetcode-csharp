namespace LeetCodeCSharpApp.KthSmallestElementInASortedMatrix03;

public class Solution
{
    public int KthSmallest(int[][] matrix, int k)
    {
        return matrix.SelectMany(x => x)
            .OrderBy(x => x)
            .ElementAt(k - 1);
    }
}
