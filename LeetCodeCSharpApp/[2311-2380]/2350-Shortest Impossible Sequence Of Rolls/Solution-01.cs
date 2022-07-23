namespace LeetCodeCSharpApp.ShortestImpossibleSequenceOfRolls01;

public class Solution
{
    public int ShortestSequence(int[] rolls, int k)
    {
        var result = 1;
        var s = new HashSet<int>();
        
        foreach (var r in rolls)
        {
            s.Add(r);

            if (s.Count != k)
                continue;

            result++;
            
            s.Clear();
        }

        return result;
    }
}
