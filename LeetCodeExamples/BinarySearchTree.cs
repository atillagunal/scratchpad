public class BinarySearchTreeSolution
{
    public TreeNode SearchBST(TreeNode root, int val)
    {
        if (root == null)
        {
            return null;
        }

        if (root.val == val)
        {
            return root;
        }

        if (val < root.val)
        {
            return SearchBST(root.left, val);
        }

        return SearchBST(root.right, val);
    }

    public TreeNode SearchBSTStack(TreeNode root, int val)
    {
        Stack<TreeNode> stack = new Stack<TreeNode>();
        stack.Push(root);

        while (stack.Count > 0)
        {
            TreeNode node = stack.Pop();

            if (node == null)
            {
                return null;
            }

            if (val == node.val)
            {
                return node;
            }

            if (val < node.val)
            {
                stack.Push(node.left);
            }
            else
            {
                stack.Push(node.right);
            }
        }

        return null;
    }
}