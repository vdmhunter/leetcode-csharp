namespace LeetCodeCSharpApp.NumbersWithSameConsecutiveDifferences01;

// We initial the current result with all 1-digit numbers,
// like cur = [1, 2, 3, 4, 5, 6, 7, 8, 9].
// 
// Each turn, for each x in cur,
// we get its last digit y = x % 10.
// If y + k < 10, we add x * 10 + y + k to the new list.
// If y - k >= 0, we add x * 10 + y - k to the new list.
// 
// We repeat this step n - 1 times and return the final result.

/// <summary>
/// BFS
/// </summary>
public class Solution
{
    // ReSharper disable once IdentifierTypo
    public int[] NumsSameConsecDiff(int n, int k)
    {
        var result = Enumerable.Range(1, 9).ToList();
        
        for (var i = 2; i <= n; ++i)
        {
            var tmp = new List<int>();
            
            foreach (var x in result)
            {
                var y = x % 10;
                
                if (y + k < 10)
                    tmp.Add(x * 10 + y + k);
                
                if (k > 0 && y - k >= 0)
                    tmp.Add(x * 10 + y - k);
            }

            result = tmp;
        }

        return result.ToArray();
    }
}
