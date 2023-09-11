namespace LeetCodeCSharpApp.GroupThePeopleGivenTheGroupSizeTheyBelongTo01;

public class Solution
{
    public IList<IList<int>> GroupThePeople(int[] groupSizes)
    {
        var tempGroup = new Dictionary<int, List<int>>();
        var result = new List<IList<int>>();

        for (var i = 0; i < groupSizes.Length; i++)
        {
            var size = groupSizes[i];

            if (!tempGroup.ContainsKey(size))
                tempGroup[size] = new List<int>();

            tempGroup[size].Add(i);

            if (tempGroup[size].Count != size)
                continue;

            result.Add(new List<int>(tempGroup[size]));
            tempGroup[size].Clear();
        }

        return result;
    }
}
