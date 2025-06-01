
public class ValidateBinarySearchFastSolution
{
    public bool IsValidBST(TreeNode root)
    {
        if (root == null)
        {
            return true;
        }

        return IsValidBST(root.left, root.val, null) &&
               IsValidBST(root.right, null, root.val);
    }

    private bool IsValidBST(TreeNode node, int? upperBound, int? lowerBound)
    {
        if (node == null)
        {
            return true;
        }

        if ((upperBound != null && node.val >= upperBound) ||
            (lowerBound != null && node.val <= lowerBound) ||
            IsValidBST(node.left, node.val, lowerBound) == false ||
            IsValidBST(node.right, upperBound, node.val) == false)
        {
            return false;
        }

        return true;
    }
}

