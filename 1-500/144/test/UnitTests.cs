
namespace test;

public class UnitTests
{
    [Fact]
    public void Initial_Tests()
    {
        var solution = new Solution();
        var list = new TreeNode(1, null, new TreeNode(2, new TreeNode(3)));
        var result = solution.PostorderTraversal(list);
        Assert.Equal(new[]{3,2,1}, result);
    }
}
