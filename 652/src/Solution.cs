using Common;
namespace src;

public class Solution
{
    IList<TreeNode> array = new List<TreeNode>();
    TreeNode leftRoot;
    TreeNode rightRoot;
    public IList<TreeNode> FindDuplicateSubtrees(TreeNode root)
    {
        if (IsEqualTrees(root.left, root.right))
        { 
            array.Add(root.left);
        }

    }


    public bool IsEqualTrees(TreeNode firstTree, TreeNode secondTree)
    {
        bool result = true;

        // сравниваем ноды
        if (firstTree != null && secondTree != null)
        {
            if (firstTree.val != secondTree.val ||
            !IsEqualTrees(firstTree.left, secondTree.left) ||
            !IsEqualTrees(firstTree.right, secondTree.right) ||
            (firstTree.left == null && secondTree.left != null) ||
            (firstTree.left != null && secondTree.left == null)
            )
            {
                return false;
            }

        }

        return result;
    }

     public bool IsEqualSubTrees(TreeNode firstTree, TreeNode secondTree)
    {
        bool result = true;

        // сравниваем ноды
        if (firstTree != null && secondTree != null)
        {
            if (firstTree.val != secondTree.val ||
            !IsEqualTrees(firstTree.left, secondTree.left) ||
            !IsEqualTrees(firstTree.right, secondTree.right) ||
            !IsEqualTrees(firstTree.right, secondTree.right.left) ||
            (firstTree.left == null && secondTree.left != null) ||
            (firstTree.left != null && secondTree.left == null)
            )
            {
                return false;
            }

        }

        return result;
    }
}