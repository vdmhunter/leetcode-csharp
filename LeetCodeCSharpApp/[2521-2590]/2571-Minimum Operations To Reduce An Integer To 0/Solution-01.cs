namespace LeetCodeCSharpApp.MinimumOperationsToReduceAnIntegerTo0_01;

public class Solution
{
    public int MinOperations(int n)
    {
        if (n == 0)
            return 0;
        
        var x = Convert.ToInt32(Math.Floor(Math.Log2(n)));
        var y = Convert.ToInt32(Math.Ceiling(Math.Log2(n)));
        var px = Math.Abs(Math.Pow(2, x) - n);
        var py = Math.Abs(Math.Pow(2, y) - n);
        
        if (px > py)
            return 1 + MinOperations(Convert.ToInt32(py));

        return 1 + MinOperations(Convert.ToInt32(px));
    }
}

