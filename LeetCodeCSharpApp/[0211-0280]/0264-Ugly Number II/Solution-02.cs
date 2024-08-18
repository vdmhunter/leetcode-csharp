namespace LeetCodeCSharpApp.UglyNumberII02;

public class Solution
{
    public int NthUglyNumber(int n)
    {
        var minHeap = new PriorityQueue<long, long>();
        var seenNumbers = new HashSet<long>();
        int[] primeFactors = [2, 3, 5];

        minHeap.Enqueue(1L, 1L);
        seenNumbers.Add(1L);

        var currentUgly = 1L;

        for (var i = 0; i < n; i++)
        {
            currentUgly = minHeap.Dequeue();

            foreach (int prime in primeFactors)
            {
                long nextUgly = currentUgly * prime;

                if (seenNumbers.Add(nextUgly))
                    minHeap.Enqueue(nextUgly, nextUgly);
            }
        }

        return (int)currentUgly;
    }
}
