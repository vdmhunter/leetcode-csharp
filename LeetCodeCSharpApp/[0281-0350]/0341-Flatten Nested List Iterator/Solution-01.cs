using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.FlattenNestedListIterator01;

public class NestedIterator
{
    private readonly IEnumerator<int> _enumerator;
    private bool _hasNext;

    public NestedIterator(IList<NestedInteger> nestedList)
    {
        _enumerator = GetIntegers(nestedList).GetEnumerator();
        _hasNext = _enumerator.MoveNext();
    }

    public bool HasNext()
    {
        return _hasNext;
    }

    public int Next()
    {
        var result = _enumerator.Current;
        _hasNext = _enumerator.MoveNext();

        return result;
    }

    private static IEnumerable<int> GetIntegers(IList<NestedInteger> nestedIntegers)
    {
        return nestedIntegers
            .Select(ni => ni.IsInteger()
                ? new[] { ni.GetInteger() }
                : GetIntegers(ni.GetList()))
            .SelectMany(i => i);
    }
}
