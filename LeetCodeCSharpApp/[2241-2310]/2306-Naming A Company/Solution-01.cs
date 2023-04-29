namespace LeetCodeCSharpApp.NamingACompany01;

public class Solution
{
    public long DistinctNames(string[] ideas)
    {
        var dict = new Dictionary<char, HashSet<string>>();

        //Initially map the key as first letter from the hint of question and value is string
        foreach (var idea in ideas)
        {
            if (!dict.ContainsKey(idea[0]))
                dict.Add(idea[0], new HashSet<string>());

            dict[idea[0]].Add(idea);
        }

        var set = new Dictionary<char, Dictionary<char, long>>();

        //Generate All possible combinations of the company name
        foreach (var idea1 in dict.Keys)
        {
            set.Add(idea1, new Dictionary<char, long>());

            foreach (var idea2 in dict.Keys.Where(idea2 => idea1 != idea2))
            {
                set[idea1].Add(idea2, 0);

                foreach (var _ in dict[idea2].Select(str => $"{idea1}" + str[1..])
                             .Where(posCompany => !dict[idea1].Contains(posCompany)))
                {
                    set[idea1][idea2]++;
                }
            }
        }

        // Compute the which all are distinct.

        return dict.Keys.Sum(idea1 =>
            dict.Keys.Where(idea2 => idea1 != idea2).Sum(idea2 => set[idea1][idea2] * set[idea2][idea1]));
    }
}
