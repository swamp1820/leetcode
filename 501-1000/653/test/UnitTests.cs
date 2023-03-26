
namespace test;

public class UnitTests
{
    [Fact]
    public void Initial_Test()
    {
        var solution = new Solution();
        var list = new TreeNode(5, new TreeNode(3, new TreeNode(2), new TreeNode(4)),new TreeNode(6, null, new TreeNode(7)));
        var result = solution.FindTarget(list, 9);
        Assert.True(result);
    }
}
