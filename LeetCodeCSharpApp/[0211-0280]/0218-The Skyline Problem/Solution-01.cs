namespace LeetCodeCSharpApp.TheSkylineProblem01;

public class Solution
{
    public IList<IList<int>> GetSkyline(int[][] buildings)
    {
        return Merge(buildings, 0, buildings.Length - 1);
    }

    private IList<IList<int>> Merge(int[][] buildings, int lo, int hi)
    {
        var result = new List<IList<int>>();
        
        if (lo > hi)
            return result;

        if (lo == hi)
        {
            result.Add(new[] { buildings[lo][0], buildings[lo][2] });
            result.Add(new[] { buildings[lo][1], 0 });
            
            return result;
        }

        var mid = lo + (hi - lo) / 2;
        var left = Merge(buildings, lo, mid);
        var right = Merge(buildings, mid + 1, hi);
        int leftH = 0, rightH = 0;
        
        while (left.Count != 0 || right.Count != 0)
        {
            var x1 = left.Count == 0 ? long.MaxValue : left[0][0];
            var x2 = right.Count == 0 ? long.MaxValue : right[0][0];
            int x;
            
            if (x1 < x2)
            {
                var temp = left[0].ToArray();
                left.RemoveAt(0);
                x = temp[0];
                leftH = temp[1];
            }
            else if (x1 > x2)
            {
                var temp = right[0].ToArray();
                right.RemoveAt(0);
                x = temp[0];
                rightH = temp[1];
            }
            else
            {
                x = left[0][0];
                leftH = left[0][1];
                left.RemoveAt(0);
                rightH = right[0][1];
                right.RemoveAt(0);
            }

            var h = Math.Max(leftH, rightH);
            
            if (result.Count == 0 || h != result[^1][1])
                result.Add(new[] { x, h });
        }

        return result;
    }
}
