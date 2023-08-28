namespace LeetCodeCSharpApp.FrogJump01;

public class Solution
{
    public bool CanCross(int[] stones)
    {
        if (stones == null || stones.Length == 0)
            return false;

        var n = stones.Length;
        var stepsAtStone = InitializeStepsAtStone(stones);

        foreach (var stone in stones)
        {
            var possibleStepsFromStone = stepsAtStone[stone];
            UpdatePossibleSteps(stepsAtStone, stone, possibleStepsFromStone);
        }

        return stepsAtStone[stones[n - 1]].Count > 0;
    }

    private static Dictionary<int, HashSet<int>> InitializeStepsAtStone(int[] stones)
    {
        var stepsAtStone = new Dictionary<int, HashSet<int>>();

        foreach (var stone in stones)
            stepsAtStone[stone] = new HashSet<int>();

        stepsAtStone[0].Add(0);

        return stepsAtStone;
    }

    private static void UpdatePossibleSteps(Dictionary<int, HashSet<int>> stepsAtStone, int stone,
        HashSet<int> possibleStepsFromStone)
    {
        foreach (var step in possibleStepsFromStone)
            for (var adjustedStep = step - 1; adjustedStep <= step + 1; adjustedStep++)
                if (adjustedStep > 0 && stepsAtStone.ContainsKey(stone + adjustedStep))
                    stepsAtStone[stone + adjustedStep].Add(adjustedStep);
    }
}
