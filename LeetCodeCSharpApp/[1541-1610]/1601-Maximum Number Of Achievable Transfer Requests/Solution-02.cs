namespace LeetCodeCSharpApp.MaximumNumberOfAchievableTransferRequests02;

public class Solution
{
    private int _result;

    public int MaximumRequests(int n, int[][] requests)
    {
        var indegree = new int[n];
        MaxRequest(requests, indegree, n, 0, 0);

        return _result;
    }

    private void MaxRequest(int[][] requests, int[] indegree, int n, int index, int count)
    {
        if (index == requests.Length)
        {
            // Check if all buildings have an in-degree of 0.
            for (var i = 0; i < n; i++)
                if (indegree[i] != 0)
                    return;

            _result = Math.Max(_result, count);

            return;
        }

        // Consider this request, increment and decrement for the buildings involved.
        indegree[requests[index][0]]--;
        indegree[requests[index][1]]++;
        // Move on to the next request and also increment the count of requests.
        MaxRequest(requests, indegree, n, index + 1, count + 1);
        // Backtrack to the previous values to move back to the original state before the second recursion.
        indegree[requests[index][0]]++;
        indegree[requests[index][1]]--;

        // Ignore this request and move on to the next request without incrementing the count.
        MaxRequest(requests, indegree, n, index + 1, count);
    }
}
