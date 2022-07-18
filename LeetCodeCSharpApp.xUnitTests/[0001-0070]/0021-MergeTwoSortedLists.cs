// ReSharper disable InconsistentNaming
// ReSharper disable ConvertToConstant.Local

using System.Diagnostics.CodeAnalysis;
using LeetCodeCSharpApp.Common;
using Xunit;
using Solution01 = LeetCodeCSharpApp.MergeTwoSortedLists01;

namespace LeetCodeCSharpApp.xUnitTests;

[ExcludeFromCodeCoverage]
public class MergeTwoSortedListsTests
{
    private readonly Solution01.Solution _solution01;

    private const string ProblemName = "0021-Merge Two Sorted Lists";

    #region Test Case 001

    private readonly ListNode _testcase001_list1 = new(1, new ListNode(2, new ListNode(4)));
    private readonly ListNode _testcase001_list2 = new(1, new ListNode(3, new ListNode(4)));

    private readonly ListNode _testcase001_output =
        new(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(4))))));

    #endregion
    
    #region Test Case 002

    private readonly ListNode _testcase002_list1 = null!;
    private readonly ListNode _testcase002_list2 = null!;

    private readonly ListNode _testcase002_output = null!;

    #endregion
    
    #region Test Case 003

    private readonly ListNode _testcase003_list1 = null!;
    private readonly ListNode _testcase003_list2 = new();

    private readonly ListNode _testcase003_output = new();

    #endregion
    
    #region Test Case 004

    private readonly ListNode _testcase004_list1 = new();
    private readonly ListNode _testcase004_list2 = null!;

    private readonly ListNode _testcase004_output = new();

    #endregion

    public MergeTwoSortedListsTests()
    {
        _solution01 = new Solution01.Solution();
    }

    #region Solution-01

    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-01")]
    public void Solution01_TestCase001()
    {
        var output = _solution01.MergeTwoLists(_testcase001_list1, _testcase001_list2);
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
        var output = _solution01.MergeTwoLists(_testcase002_list1, _testcase002_list2);
        Assert.Equal(_testcase002_output, output);
    }
    
    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-01")]
    public void Solution01_TestCase003()
    {
        var output = _solution01.MergeTwoLists(_testcase003_list1, _testcase003_list2);
        Assert.Equal(_testcase003_output.val, output.val);
    }
    
    [Fact]
    [Trait("Category", $"{ProblemName}: Solution-01")]
    public void Solution01_TestCase004()
    {
        var output = _solution01.MergeTwoLists(_testcase004_list1, _testcase004_list2);

        var expected = _testcase004_output;
        var actual = output;
        
        if(expected == null! && actual == null!)
            Assert.Equal(expected, actual);
        else
            while (expected != null! && actual != null!)
            {
                Assert.Equal(expected.val, actual.val);
                
                expected = expected.next;
                actual = actual.next;
            }
    }

    #endregion
}
