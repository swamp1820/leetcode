

namespace test;

public class UnitTests
{
    [Fact]
    public void Initial_Tests()
    {
        var solution = new Solution();
        var list1 = new ListNode(1, new ListNode(2, new ListNode(3)));
        var result = solution.ReverseList(list1);
        Assert.Equal(new ListNode(3, new ListNode(2, new ListNode(1))), result);
    }
}
