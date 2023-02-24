namespace test;

public class UnitTests
{
    [Fact]
    public void ListNode_ToEnumerable_Tests()
    {
        var input = new ListNode(1, new ListNode(3, new ListNode(7)));
        Assert.Equal(input.ToIEnumerable(), new int[]{1,3,7});
    }

    [Fact]
    public void ListNode_FromEnumerable_Tests()
    {
        var result = new ListNode(new int[]{1,3,7});
        var expected = new ListNode(1, new ListNode(3, new ListNode(7)));
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ListNode_AddLast_Tests()
    {
        var node = new ListNode(1, new ListNode(3));
        node.AddNode(7);
        var expected = new ListNode(1, new ListNode(3, new ListNode(7)));
        Assert.Equal(expected, node);
    }
}
