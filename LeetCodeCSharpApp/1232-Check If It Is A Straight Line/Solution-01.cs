namespace LeetCodeCSharpApp.CheckIfItIsAStraightLine01;

public class Solution
{
    public bool CheckStraightLine(int[][] coordinates)
    {
        if (coordinates == null)
            return false;
        
        if(coordinates.Length == 2)
            return true;
        
        if (coordinates.Length < 3 || coordinates[0].Length == 0)
            return false;

        var p = coordinates[0];
        var q = coordinates[1];

        for (var i = 2; i < coordinates.Length; i++)
        {
            var curr = coordinates[i];

            if ((curr[0] - p[0]) * (q[1] - p[1]) != (curr[1] - p[1]) * (q[0] - p[0]))
                return false;
        }

        return true;
    }
}
