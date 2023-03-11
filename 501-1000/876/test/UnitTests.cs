

namespace test;

public class UnitTests
{
    [Fact]
    public void Initial_Tests()
    {
        var solution = new Solution();
        var list = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5,new ListNode(6))))));
        var result = solution.MiddleNode(list);
        Assert.Equal(new ListNode(4, new ListNode(5,new ListNode(6))), result);
    }
}
