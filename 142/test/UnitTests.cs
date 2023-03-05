

namespace test;

public class UnitTests
{
    [Fact]
    public void Initial_Tests()
    {
        var solution = new Solution();
        var cycle = new ListNode(2, new ListNode(3, new ListNode(4)));
        var list = new ListNode(1, cycle);
        var result = solution.DetectCycle(list);
        Assert.Equal(cycle, result);
    }
}
