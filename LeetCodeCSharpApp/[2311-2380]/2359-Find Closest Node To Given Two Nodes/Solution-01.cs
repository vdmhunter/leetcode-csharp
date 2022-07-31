namespace LeetCodeCSharpApp.FindClosestNodeToGivenTwoNodes01;

public class Solution
{
    public int ClosestMeetingNode(int[] edges, int node1, int node2)
    {
        Dictionary<int, int> d1 = new(), d2 = new();
        int iterIndex = node1, distance = 0;
        
        while (iterIndex != -1 && !d1.ContainsKey(iterIndex))
        {
            d1[iterIndex] = distance++;
            iterIndex = edges[iterIndex];
        }

        int resultIndex = int.MaxValue, resultDistance = int.MaxValue;
        iterIndex = node2;
        distance = 0;
        
        while (iterIndex != -1 && !d2.ContainsKey(iterIndex))
        {
            d2[iterIndex] = distance++;

            if (d1.ContainsKey(iterIndex))
            {
                var m = Math.Max(d1[iterIndex], d2[iterIndex]);
                
                if (m < resultDistance || (m == resultDistance && iterIndex < resultIndex))
                {
                    resultIndex = iterIndex;
                    resultDistance = m;
                }
            }

            iterIndex = edges[iterIndex];
        }

        if (resultIndex == int.MaxValue)
            return -1;
        
        return resultIndex;
    }
}
