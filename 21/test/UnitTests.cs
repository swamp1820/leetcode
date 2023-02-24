

namespace test;

public class UnitTests
{
    [Fact]
    public void Initial_Tests()
    {
        var solution = new Solution();
        var list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
        var list2 = new ListNode(1, new ListNode(3, new ListNode(4)));
        var result = solution.MergeTwoLists(list1,list2);
        Assert.Equal(new int[]{1,1,2,3,4,4}, result.ToIEnumerable());
    }
}
