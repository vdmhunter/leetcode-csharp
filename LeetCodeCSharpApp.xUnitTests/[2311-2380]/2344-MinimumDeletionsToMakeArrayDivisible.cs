// ReSharper disable InconsistentNaming
// ReSharper disable ConvertToConstant.Local

using System.Diagnostics.CodeAnalysis;
using Xunit;
using Solution01 = LeetCodeCSharpApp.MinimumDeletionsToMakeArrayDivisible01;

namespace LeetCodeCSharpApp.xUnitTests;

[ExcludeFromCodeCoverage]
public class MinimumDeletionsToMakeArrayDivisibleTests
{
    private readonly Solution01.Solution _solution01;

    private const string ProblemName = "2344-Minimum Deletions To Make Array Divisible";

    #region Test Case 001

    private readonly int[] _testcase001_nums = { 2, 3, 2, 4, 3 };
    private readonly int[] _testcase001_numsDivide = { 9, 6, 9, 3, 15 };
    private readonly int _testcase001_output = 2;

    #endregion

    #region Test Case 002

    private readonly int[] _testcase002_nums = { 4, 3, 6 };
    private readonly int[] _testcase002_numsDivide = { 8, 2, 6, 10 };
    private readonly int _testcase002_output = -1;

    #endregion

    public MinimumDeletionsToMakeArrayDivisibleTests()
    {
        _solution01 = new Solution01.Solution();
    }

    #region Solution-01

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-01")]
    public void Solution01_TestCase001()
    {
        var output = _solution01.MinOperations(_testcase001_nums, _testcase001_numsDivide);
        Assert.Equal(_testcase001_output, output);
    }

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-01")]
    public void Solution01_TestCase002()
    {
        var output = _solution01.MinOperations(_testcase002_nums, _testcase002_numsDivide);
        Assert.Equal(_testcase002_output, output);
    }

    #endregion
}
