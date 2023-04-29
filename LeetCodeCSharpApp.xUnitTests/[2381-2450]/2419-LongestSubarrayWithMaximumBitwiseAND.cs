// ReSharper disable InconsistentNaming
// ReSharper disable ConvertToConstant.Local

using System.Diagnostics.CodeAnalysis;
using Xunit;
using Solution01 = LeetCodeCSharpApp.LongestSubarrayWithMaximumBitwiseAND01;

namespace LeetCodeCSharpApp.xUnitTests;

[ExcludeFromCodeCoverage]
public class LongestSubarrayWithMaximumBitwiseANDTests
{
    private readonly Solution01.Solution _solution01;

    private const string ProblemName = "2419-Longest Subarray With Maximum Bitwise AND";

    #region Test Case 001

    private readonly int[] _testcase001_nums = { 1, 2, 3, 3, 2, 2 };

    private readonly int _testcase001_output = 2;

    #endregion

    #region Test Case 002

    private readonly int[] _testcase002_nums = { 1, 2, 3, 4 };
    private readonly int _testcase002_output = 1;

    #endregion

    #region Test Case 003

    private readonly int[] _testcase003_nums =
        { 96317, 96317, 96317, 96317, 96317, 96317, 96317, 96317, 96317, 279979 };

    private readonly int _testcase003_output = 1;

    #endregion

    public LongestSubarrayWithMaximumBitwiseANDTests()
    {
        _solution01 = new Solution01.Solution();
    }

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-01")]
    public void Solution01_TestCase001()
    {
        var output = _solution01.LongestSubarray(_testcase001_nums);
        Assert.Equal(_testcase001_output, output);
    }

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-01")]
    public void Solution01_TestCase002()
    {
        var output = _solution01.LongestSubarray(_testcase002_nums);
        Assert.Equal(_testcase002_output, output);
    }

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-01")]
    public void Solution01_TestCase003()
    {
        var output = _solution01.LongestSubarray(_testcase003_nums);
        Assert.Equal(_testcase003_output, output);
    }
}
