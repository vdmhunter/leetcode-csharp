// ReSharper disable InconsistentNaming

using System.Diagnostics.CodeAnalysis;
using Xunit;
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

    private const string ProblemName = "0724-My Calendar III";

    #region Test Case 001

    private readonly int[][] _testcase001_input =
        { new[] { 10, 20 }, new[] { 50, 60 }, new[] { 10, 40 }, new[] { 5, 15 }, new[] { 5, 10 }, new[] { 25, 55 } };

    private readonly int[] _testcase001_output = { 1, 1, 2, 3, 3, 3 };

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
        var output0 = _solution01.Book(_testcase001_input[0][0], _testcase001_input[0][1]);
        var output1 = _solution01.Book(_testcase001_input[1][0], _testcase001_input[1][1]);
        var output2 = _solution01.Book(_testcase001_input[2][0], _testcase001_input[2][1]);
        var output3 = _solution01.Book(_testcase001_input[3][0], _testcase001_input[3][1]);
        var output4 = _solution01.Book(_testcase001_input[4][0], _testcase001_input[4][1]);
        var output5 = _solution01.Book(_testcase001_input[5][0], _testcase001_input[5][1]);

        Assert.Multiple(
            () => Assert.Equal(_testcase001_output[0], output0),
            () => Assert.Equal(_testcase001_output[1], output1),
            () => Assert.Equal(_testcase001_output[2], output2),
            () => Assert.Equal(_testcase001_output[3], output3),
            () => Assert.Equal(_testcase001_output[4], output4),
            () => Assert.Equal(_testcase001_output[5], output5)
        );
    }

    #endregion
    
    #region Solution-02

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-02")]
    public void Solution02_TestCase001()
    {
        var output0 = _solution02.Book(_testcase001_input[0][0], _testcase001_input[0][1]);
        var output1 = _solution02.Book(_testcase001_input[1][0], _testcase001_input[1][1]);
        var output2 = _solution02.Book(_testcase001_input[2][0], _testcase001_input[2][1]);
        var output3 = _solution02.Book(_testcase001_input[3][0], _testcase001_input[3][1]);
        var output4 = _solution02.Book(_testcase001_input[4][0], _testcase001_input[4][1]);
        var output5 = _solution02.Book(_testcase001_input[5][0], _testcase001_input[5][1]);

        Assert.Multiple(
            () => Assert.Equal(_testcase001_output[0], output0),
            () => Assert.Equal(_testcase001_output[1], output1),
            () => Assert.Equal(_testcase001_output[2], output2),
            () => Assert.Equal(_testcase001_output[3], output3),
            () => Assert.Equal(_testcase001_output[4], output4),
            () => Assert.Equal(_testcase001_output[5], output5)
        );
    }

    #endregion
    
    #region Solution-03

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-03")]
    public void Solution03_TestCase001()
    {
        var output0 = _solution03.Book(_testcase001_input[0][0], _testcase001_input[0][1]);
        var output1 = _solution03.Book(_testcase001_input[1][0], _testcase001_input[1][1]);
        var output2 = _solution03.Book(_testcase001_input[2][0], _testcase001_input[2][1]);
        var output3 = _solution03.Book(_testcase001_input[3][0], _testcase001_input[3][1]);
        var output4 = _solution03.Book(_testcase001_input[4][0], _testcase001_input[4][1]);
        var output5 = _solution03.Book(_testcase001_input[5][0], _testcase001_input[5][1]);

        Assert.Multiple(
            () => Assert.Equal(_testcase001_output[0], output0),
            () => Assert.Equal(_testcase001_output[1], output1),
            () => Assert.Equal(_testcase001_output[2], output2),
            () => Assert.Equal(_testcase001_output[3], output3),
            () => Assert.Equal(_testcase001_output[4], output4),
            () => Assert.Equal(_testcase001_output[5], output5)
        );
    }

    #endregion
}
