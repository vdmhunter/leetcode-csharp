namespace LeetCodeCSharpApp.QueueReconstructionByHeight01;

public class Solution
{
    public int[][] ReconstructQueue(int[][] people)
    {
        Array.Sort(people, (a, b) => a[0] == b[0] ? a[1] - b[1] : b[0] - a[0]);
        
        var result = new List<int[]>();
        
        foreach (var p in people)
            result.Insert(p[1], p);

        return result.ToArray();
    }
}
