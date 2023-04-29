namespace LeetCodeCSharpApp.SearchSuggestionsSystem01;

/// <summary>
/// Binary Search
/// </summary>
public class Solution
{
    private static int LowerBound(IReadOnlyList<string> products, int start, string word)
    {
        int i = start, j = products.Count;

        while (i < j)
        {
            var mid = (i + j) / 2;
            if (string.Compare(products[mid], word, StringComparison.Ordinal) >= 0)
                j = mid;
            else
                i = mid + 1;
        }

        return i;
    }

    public IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
    {
        Array.Sort(products);

        var result = new List<IList<string>>();
        int bsStart = 0, n = products.Length;
        var prefix = string.Empty;

        foreach (var c in searchWord)
        {
            prefix += c;

            // Get the starting index of word starting with `prefix`.
            var start = LowerBound(products, bsStart, prefix);

            // Add empty vector to result.
            result.Add(new List<string>());

            // Add the words with the same prefix to the result.
            // Loop runs until `i` reaches the end of input or 3 times or till the
            // prefix is same for `products[i]` Whichever comes first.
            for (var i = start; i < Math.Min(start + 3, n); i++)
            {
                if (products[i].Length < prefix.Length || !products[i][..prefix.Length].Equals(prefix))
                    break;

                result[^1].Add(products[i]);
            }

            // Reduce the size of elements to binary search on since we know
            bsStart = Math.Abs(start);
        }

        return result;
    }
}
