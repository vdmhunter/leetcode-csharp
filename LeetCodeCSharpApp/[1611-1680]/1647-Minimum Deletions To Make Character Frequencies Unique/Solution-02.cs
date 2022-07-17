namespace LeetCodeCSharpApp.MinimumDeletionsToMakeCharacterFrequenciesUnique02;

public class Solution
{
    /// <summary>
    /// Priority Queue
    /// </summary>
    public int MinDeletions(string s)
    {
        // Store the frequency of each character
        var frequency = new int[26];
        foreach (var c in s)
            frequency[c - 'a']++;

        // Add the frequencies to the priority queue
        var pq = new PriorityQueue<int, int>();
        for (var i = 0; i < 26; i++)
            if (frequency[i] > 0)
                pq.Enqueue(frequency[i], -frequency[i]);

        var deleteCount = 0;
        while (pq.Count > 1)
        {
            var topElement = pq.Dequeue();

            // If the top two elements in the priority queue are the same
            if (topElement == pq.Peek())
            {
                // Decrement the popped value and push it back into the queue
                if (topElement - 1 > 0)
                    pq.Enqueue(topElement - 1, -(topElement - 1));
                
                deleteCount++;
            }
        }

        return deleteCount;
    }
}
