namespace LeetCodeCSharpApp.RelocateMarbles02;

public class Solution
{
    public IList<int> RelocateMarbles(int[] nums, int[] moveFrom, int[] moveTo)
    {
        var tmp = new HashSet<int>(nums);

        for (var i = 0; i < moveFrom.Length; i++)
        {
            tmp.Remove(moveFrom[i]);
            tmp.Add(moveTo[i]);
        }

        return tmp.OrderBy(x => x).ToList();
    }
}
