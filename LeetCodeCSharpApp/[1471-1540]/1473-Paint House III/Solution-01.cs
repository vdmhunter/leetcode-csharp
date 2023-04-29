namespace LeetCodeCSharpApp.PaintHouseIII01;

public class Solution
{
    private readonly int?[,,] _memo = new int?[101, 21, 101]; //cache
    private const int Max = (int)1e8;
    private int _m, _n;

    public int MinCost(int[] houses, int[][] cost, int m, int n, int target)
    {
        _m = m;
        _n = n;

        var res = Dfs(houses, cost, 0, 0, target);

        return res >= Max ? -1 : res;
    }

    private int Dfs(IReadOnlyList<int> houses, int[][] cost, int houseIdx, int prevColor, int target)
    {
        if (houseIdx == _m || target < 0)
            return target == 0 ? 0 : Max; //base cases

        if (_memo[houseIdx, prevColor, target] != null)
            return _memo[houseIdx, prevColor, target]!.Value; //use memoized result

        if (houses[houseIdx] != 0)
        {
            ; //already painted only need to decide if it forms a new neighborhood or not
            var currentColor = houses[houseIdx];
            _memo[houseIdx, prevColor, target] = Dfs(houses, cost, houseIdx + 1, currentColor,
                target - (currentColor != prevColor ? 1 : 0));

            return _memo[houseIdx, prevColor, target]!.Value;
        }

        var res = Max;
        for (var currentColor = 1; currentColor <= _n; currentColor++)
        {
            //check all the colors and select min one
            var val = Dfs(houses, cost, houseIdx + 1, currentColor,
                target - (currentColor != prevColor
                    ? 1
                    : 0)); //if prev color != current color means we have a new neighborhood so target - 1

            res = Math.Min(res, val + cost[houseIdx][currentColor - 1]); //store the minimum
        }

        _memo[houseIdx, prevColor, target] = res;

        return _memo[houseIdx, prevColor, target]!.Value;
    }
}
