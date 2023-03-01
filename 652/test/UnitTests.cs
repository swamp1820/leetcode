using Common;
namespace test;

public class UnitTests
{
    [Fact]
    public void Initial_Tests()
    {
        var solution = new Solution();
        var tree = new TreeNode(1, new TreeNode(2), new TreeNode(2));
        var result = solution.FindDuplicateSubtrees(tree);

        Assert.Equal(new List<TreeNode>() {
            new TreeNode(2)
        }, result);
    }

     [Fact]
    public void Initial_Test2()
    {
        var solution = new Solution();
        var tree = new TreeNode(2, new TreeNode(2,new TreeNode(3)), new TreeNode(2, new TreeNode(3)));
        var result = solution.FindDuplicateSubtrees(tree);

        Assert.Equal(new List<TreeNode>() {
            new TreeNode(2,new TreeNode(3)), new TreeNode(3)
        }, result);
    }


    [Fact]
    public void Equal_Tests()
    {
        var solution = new Solution();
        var tree1 = new TreeNode(1, new TreeNode(2, new TreeNode(4)), new TreeNode(3, new TreeNode(2, new TreeNode(4)), new TreeNode(4)));
        var tree2 = new TreeNode(1, new TreeNode(2, new TreeNode(4)), new TreeNode(3, new TreeNode(2, new TreeNode(4)), new TreeNode(4)));

        var result = solution.IsEqualTrees(tree1, tree2);

        Assert.True(result);
    }

     [Fact]
    public void Equal2_Tests()
    {
        var solution = new Solution();
        var tree1 = new TreeNode(1);
        var tree2 = new TreeNode(1);

        var result = solution.IsEqualTrees(tree1, tree2);

        Assert.True(result);
    }
    [Fact]
    public void NotEqual_Tests()
    {
        var solution = new Solution();

        var tree3 = new TreeNode(1, new TreeNode(2, new TreeNode(4)), new TreeNode(3, new TreeNode(2, new TreeNode(4)), new TreeNode(4)));
        var tree4 = new TreeNode(1, new TreeNode(3, new TreeNode(4)), new TreeNode(2, new TreeNode(2, new TreeNode(4)), new TreeNode(4)));

        var result2 = solution.IsEqualTrees(tree3, tree4);

        Assert.False(result2);
    }
    [Fact]
    public void NotEqual_Null_Tests()
    {
        var solution = new Solution();

          var tree1 = new TreeNode(1, new TreeNode(2, new TreeNode(4)), new TreeNode(3, new TreeNode(2, new TreeNode(4)), new TreeNode(4)));
        var tree2 = new TreeNode(1, new TreeNode(2), new TreeNode(3, new TreeNode(2, new TreeNode(4)), new TreeNode(4)));

        var result2 = solution.IsEqualTrees(tree1, tree2);

        Assert.False(result2);
    }
}