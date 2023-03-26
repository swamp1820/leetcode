using Common;
namespace src;

public class Solution
{   
    TreeNode result = null;
    public TreeNode SearchBST(TreeNode root, int val)
    {

        if (root.val == val)
        {
            result = root;
        }
        else if (root.val < val && root.right != null)
        {
            SearchBST(root.right, val);
        }
        else if (root.val > val && root.left != null)
        {
            SearchBST(root.left, val);
        }
        return result;

    }
}