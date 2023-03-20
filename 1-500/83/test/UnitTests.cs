using Common;
namespace test;

public class UnitTests
{
    [Fact]
    public void Initial_Test1()
    {
        var solution = new Solution();
        var result = solution.DeleteDuplicates(new ListNode(1, new ListNode(1, new ListNode(2))));
        Assert.Equal(new ListNode(1, new ListNode(2)), result);
    }

    [Fact]
    public void Initial_Test2()
    {
        var solution = new Solution();
        var result = solution.DeleteDuplicates(new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(3))))));
        Assert.Equal(new ListNode(1, new ListNode(2, new ListNode(3))), result);
    }
}