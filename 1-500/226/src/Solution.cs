using Common;
namespace src;

public class Solution
{

    public TreeNode InvertTree(TreeNode root)
    {
        if (root == null)
        {
            return root;
        }
        var s = new Stack<TreeNode>();
        var result = root;
        s.Push(root);

        while (s.Count != 0)
        {
            var node = s.Pop();
            s.Push(node.left);
            node.left = node.right;
            node.right = s.Pop();
            if (node.right != null)
            {
                s.Push(node.right);
            }
            if (node.left != null)
            {
                s.Push(node.left);
            }
        }

        return result;
    }
}