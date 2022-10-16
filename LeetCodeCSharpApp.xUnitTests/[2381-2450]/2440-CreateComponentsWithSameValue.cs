using System;
using System.Diagnostics.CodeAnalysis;
using Xunit;
using Solution01 = LeetCodeCSharpApp.CreateComponentsWithSameValue01;

namespace LeetCodeCSharpApp.xUnitTests;

[ExcludeFromCodeCoverage]
public class CreateComponentsWithSameValueTests
{
    private readonly Solution01.Solution _solution01;

    private const string ProblemName = "2440-Create Components With Same Value";

    #region Test Case 001

    private readonly int[] _testcase001_nums = { 6, 2, 2, 2, 6 };
    private readonly int[][] _testcase001_edges = { new[] { 0, 1 }, new[] { 1, 2 }, new[] { 1, 3 }, new[] { 3, 4 } };
    private readonly int _testcase001_output = 2;

    #endregion

    #region Test Case 002

    private readonly int[] _testcase002_nums = { 2 };
    private readonly int[][] _testcase002_edges = Array.Empty<int[]>();
    private readonly int _testcase002_output = 0;

    #endregion

    public CreateComponentsWithSameValueTests()
    {
        _solution01 = new Solution01.Solution();
    }

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-01")]
    public void Solution01_TestCase001()
    {
        var output = _solution01.ComponentValue(_testcase001_nums, _testcase001_edges);
        Assert.Equal(_testcase001_output, output);
    }

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-01")]
    public void Solution01_TestCase002()
    {
        var output = _solution01.ComponentValue(_testcase002_nums, _testcase002_edges);
        Assert.Equal(_testcase002_output, output);
    }
}
