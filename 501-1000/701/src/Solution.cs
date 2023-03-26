using Common;
namespace src;

public class Solution
{

    public TreeNode InsertIntoBST(TreeNode root, int val)
    {
        if (root == null)
        {
            return new TreeNode(val);
        }
        var result = root;
        while (true)
        {
            if (val < root.val)
            {
                if (root.left == null)
                {
                    root.left = new TreeNode(val);
                    return result;
                }

                root = root.left;
                continue;
            }
            else if (val > root.val)
            {
                if (root.right == null)
                {
                    root.right = new TreeNode(val);
                    return result;
                }

                root = root.right;
                continue;
            }
        }
    }
}