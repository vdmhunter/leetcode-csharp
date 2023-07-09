namespace LeetCodeCSharpApp.RelocateMarbles01;

public class Solution
{
    public IList<int> RelocateMarbles(int[] nums, int[] moveFrom, int[] moveTo)
    {
        var positions = new HashSet<int>(nums);

        for (var i = 0; i < moveFrom.Length; i++)
        {
            if (!positions.Contains(moveFrom[i]))
                continue;

            positions.Remove(moveFrom[i]);
            positions.Add(moveTo[i]);
        }

        var result = new int[positions.Count];
        positions.CopyTo(result);
        Array.Sort(result);

        return result;
    }
}
