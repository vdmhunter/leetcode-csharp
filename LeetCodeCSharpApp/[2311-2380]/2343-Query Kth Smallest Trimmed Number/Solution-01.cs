using System.Numerics;

namespace LeetCodeCSharpApp.QueryKthSmallestTrimmedNumber01;

// ["89288488870527604910029","36097185739782752175822","66626740310751086142991","39210310199276100943112","27763774389382535382104","38417381130871656561097","88045540666254006395713","95788007927435793172832","15831923319620654311625","45043895456202186804606","87291364237858759125697","88163116582250002569968","00507332488046565482379","57170661333341274356658","06401271520738451116188","21731485952024837866860"]
// [[3,17],[10,22],[13,21],[12,16],[1,23],[10,19],[12,21],[10,5],[12,9],[12,10],[9,5],[12,8],[14,6],[5,10],[11,4],[15,15],[13,9],[1,19],[5,12],[10,15],[4,18],[4,3],[16,13],[6,19],[4,18],[2,6],[15,12]]

public class Solution
{
    public int[] SmallestTrimmedNumbers(string[] nums, int[][] queries)
    {
        var ans = new List<int>(queries.Length);

        foreach (var query in queries)
        {
            var bigNums = nums.Select(n =>
            {
                var trimmedStr = n[^query[1]..];
                return BigInteger.TryParse(trimmedStr, out var trimmedInt)
                    ? trimmedInt
                    : BigInteger.Parse(n);
            }).ToList();
            
            var smallest = bigNums.Select((n, i) => (n, i))
                .OrderBy(e => (e.n, e.i))
                .ElementAt(query[0] - 1);

            ans.Add(smallest.i);
        }

        return ans.ToArray();
    }
}
