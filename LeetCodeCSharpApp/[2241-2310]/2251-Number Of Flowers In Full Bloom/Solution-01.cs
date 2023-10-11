namespace LeetCodeCSharpApp.NumberOfFlowersInFullBloom01;

public class Solution
{
    public int[] FullBloomFlowers(int[][] flowers, int[] people)
    {
        var events = people.Select((t, i) => (Time: t, Type: 1, Index: i)).ToList();

        foreach (var flower in flowers)
        {
            events.Add((flower[0], 0, -1));
            events.Add((flower[1], 2, -1));
        }

        events.Sort();

        var result = new int[people.Length];
        var blooms = 0;

        foreach (var e in events)
        {
            switch (e.Type)
            {
                case 0:
                    blooms++;
                    break;
                case 2:
                    blooms--;
                    break;
                default:
                    result[e.Index] = blooms;
                    break;
            }
        }

        return result;
    }
}
