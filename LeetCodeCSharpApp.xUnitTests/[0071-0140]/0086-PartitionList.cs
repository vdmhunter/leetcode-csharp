// ReSharper disable InconsistentNaming
// ReSharper disable ConvertToConstant.Local

using System.Diagnostics.CodeAnalysis;
using LeetCodeCSharpApp.Common;
using Xunit;
using Solution01 = LeetCodeCSharpApp.PartitionList01;

namespace LeetCodeCSharpApp.xUnitTests;

[ExcludeFromCodeCoverage]
public class PartitionListTests
{
    private readonly Solution01.Solution _solution01;

    private const string ProblemName = "0724-Partition List";

    #region Test Case 001

    private readonly ListNode _testcase001_head =
        new(1, new ListNode(4, new ListNode(3, new ListNode(2, new ListNode(5, new ListNode(2))))));
    private readonly int _testcase001_x = 3;

    private readonly ListNode _testcase001_output =
        new(1, new ListNode(2, new ListNode(2, new ListNode(4, new ListNode(3, new ListNode(5))))));

    #endregion
    
    #region Test Case 002

    private readonly ListNode _testcase002_head = new(2, new ListNode(1));
    private readonly int _testcase002_x = 2;

    private readonly ListNode _testcase002_output = new(1, new ListNode(2));

    #endregion

    public PartitionListTests()
    {
        _solution01 = new Solution01.Solution();
    }

    #region Solution-01

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-01")]
    public void Solution01_TestCase001()
    {
        var output = _solution01.Partition(_testcase001_head, _testcase001_x);
        Assert.Equal(_testcase001_output.val, output.val);
        Assert.Equal(_testcase001_output.next.val, output.next.val);
        Assert.Equal(_testcase001_output.next.next.val, output.next.next.val);
        Assert.Equal(_testcase001_output.next.next.next.val, output.next.next.next.val);
        Assert.Equal(_testcase001_output.next.next.next.next.val, output.next.next.next.next.val);
        Assert.Equal(_testcase001_output.next.next.next.next.next.val, output.next.next.next.next.next.val);
    }
    
    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-01")]
    public void Solution01_TestCase002()
    {
        var output = _solution01.Partition(_testcase002_head, _testcase002_x);
        Assert.Equal(_testcase002_output.val, output.val);
        Assert.Equal(_testcase002_output.next.val, output.next.val);
    }

    #endregion
}
