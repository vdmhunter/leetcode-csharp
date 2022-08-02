namespace LeetCodeCSharpApp.KthSmallestElementInASortedMatrix02;

public class Solution
{
    public int KthSmallest(int[][] matrix, int k)
    {
        var pq = new PriorityQueue<int, int>();
        
        foreach (var i in matrix)
            foreach (var j in i)
            {
                pq.Enqueue(j, -j);
                
                if (pq.Count > k)
                    pq.Dequeue();
            }

        return pq.Peek();
    }
}
