// ReSharper disable InconsistentNaming
// ReSharper disable ConvertToConstant.Local

using System.Diagnostics.CodeAnalysis;
using Xunit;
using Solution01 = LeetCodeCSharpApp.MaximumSegmentSumAfterRemovals01;

namespace LeetCodeCSharpApp.xUnitTests;

[ExcludeFromCodeCoverage]
public class MaximumSegmentSumAfterRemovalsTests
{
    private readonly Solution01.Solution _solution01;

    private const string ProblemName = "2382-Maximum Segment Sum After Removals";

    #region Test Case 001

    private readonly int[] _testcase001_nums = { 1, 2, 5, 6, 1 };
    private readonly int[] _testcase001_removeQueries = { 0, 3, 2, 4, 1 };
    private readonly long[] _testcase001_output = { 14, 7, 2, 2, 0 };

    #endregion

    #region Test Case 002

    private readonly int[] _testcase002_nums = { 3, 2, 11, 1 };
    private readonly int[] _testcase002_removeQueries = { 3, 2, 1, 0 };
    private readonly long[] _testcase002_output = { 16, 5, 3, 0 };

    #endregion

    public MaximumSegmentSumAfterRemovalsTests()
    {
        _solution01 = new Solution01.Solution();
    }

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-01")]
    public void Solution01_TestCase001()
    {
        var output = _solution01.MaximumSegmentSum(_testcase001_nums, _testcase001_removeQueries);
        Assert.Equal(_testcase001_output, output);
    }

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-01")]
    public void Solution01_TestCase002()
    {
        var output = _solution01.MaximumSegmentSum(_testcase002_nums, _testcase002_removeQueries);
        Assert.Equal(_testcase002_output, output);
    }
}
