namespace LeetCodeCSharpApp.KthSmallestElementInASortedMatrix01;

public class Solution
{
    public int KthSmallest(int[][] matrix, int k)
    {
        var heap = new SortedSet<(int val, int row, int col)>();
        var n = matrix.Length;
        // smallest element
        heap.Add((matrix[0][0], 0, 0));
        
        while (k > 1)
        {
            var min = heap.Min;
            heap.Remove(min); //pick the minimum out of all the possible positions you have.

            //Next position to explore
            var dirs = new[] { new[] { 0, 1 }, new[] { 1, 0 } };
            
            foreach (var dir in dirs)
            {
                int nextRow = min.row + dir[0], nextCol = min.col + dir[1];
                
                if (nextRow < n && nextCol < n)
                    heap.Add((matrix[nextRow][nextCol], nextRow, nextCol));
            }

            k--;
        }

        return heap.Min.val;
    }
}
