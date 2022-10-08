// ReSharper disable InconsistentNaming

using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Xunit;
using Xunit.Sdk;
using Solution01 = LeetCodeCSharpApp.MyCalendarIII01;
using Solution02 = LeetCodeCSharpApp.MyCalendarIII02;
using Solution03 = LeetCodeCSharpApp.MyCalendarIII03;

namespace LeetCodeCSharpApp.xUnitTests;

[ExcludeFromCodeCoverage]
public class MyCalendarIIITests
{
    private readonly Solution01.MyCalendarThree _solution01;
    private readonly Solution02.MyCalendarThree _solution02;
    private readonly Solution03.MyCalendarThree _solution03;

    private const string ProblemName = "0732-My Calendar III";

    #region Test Case 001

    private readonly int[][] _testcase001_input =
    {
        new[] { 10, 20 }, new[] { 50, 60 }, new[] { 10, 40 }, new[] { 5, 15 }, new[] { 5, 10 }, new[] { 25, 55 }
    };
    private readonly int[] _testcase001_output = { 1, 1, 2, 3, 3, 3 };

    #endregion

    #region Test Case 005

    private readonly int[][] _testcase005_input =
    {
        new[] { 24, 40 }, new[] { 43, 50 }, new[] { 27, 43 }, new[] { 5, 21 }, new[] { 30, 40 }, new[] { 14, 29 },
        new[] { 3, 19 }, new[] { 3, 14 }, new[] { 25, 39 }, new[] { 6, 19 }
    };
    private readonly int[] _testcase005_output = { 1, 1, 2, 2, 3, 3, 3, 3, 4, 4 };

    #endregion

    public MyCalendarIIITests()
    {
        _solution01 = new Solution01.MyCalendarThree();
        _solution02 = new Solution02.MyCalendarThree();
        _solution03 = new Solution03.MyCalendarThree();
    }

    #region Solution-01

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-01")]
    public void Solution01_TestCase001()
    {
        var output = _testcase001_input.Select(i => _solution01.Book(i[0], i[1]));
        Assert.Equal(_testcase001_output, output);
    }
    
    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-01")]
    public void Solution01_TestCase005()
    {
        var output = _testcase005_input.Select(i => _solution01.Book(i[0], i[1]));
        Assert.Equal(_testcase005_output, output);
    }

    #endregion

    #region Solution-02

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-02")]
    public void Solution02_TestCase001()
    {
        var output = _testcase001_input.Select(i => _solution02.Book(i[0], i[1]));
        Assert.Equal(_testcase001_output, output);
    }
    
    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-02")]
    public void Solution02_TestCase005()
    {
        var output = _testcase005_input.Select(i => _solution02.Book(i[0], i[1]));
        Assert.Equal(_testcase005_output, output);
    }

    #endregion

    #region Solution-03

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-03")]
    public void Solution03_TestCase001()
    {
        var output = _testcase001_input.Select(i => _solution03.Book(i[0], i[1])).ToArray();
        Assert.Equal(_testcase001_output, output);
    }
    
    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-03")]
    public void Solution03_TestCase005()
    {
        var output = _testcase005_input.Select(i => _solution03.Book(i[0], i[1])).ToArray();
        Assert.Equal(_testcase005_output, output);
    }

    #endregion
}
