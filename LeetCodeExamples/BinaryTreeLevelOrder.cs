

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class TraversalNode
{
    public TreeNode node;
    public int level;

    public TraversalNode(TreeNode n, int l)
    {
        node = n;
        level = l;
    }
}

public class BinaryTreeLevelOrderSolution
{
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        List<IList<int>> result = new List<IList<int>>();

        if (root == null)
        {
            return result;
        }
        
        Queue<TraversalNode> toProcess = new Queue<TraversalNode>();

        toProcess.Enqueue(new TraversalNode(root, 1));

        while (toProcess.Count > 0)
        {
            TraversalNode currentNode = toProcess.Dequeue();

            // if this level does not have a list create it
            if (result.Count < currentNode.level)
            {
                List<int> levelList = new List<int>();
                result.Add(levelList);
            }

            result[currentNode.level - 1].Add(currentNode.node.val);

            if (currentNode.node.left != null)
            {
                toProcess.Enqueue(new TraversalNode(currentNode.node.left, currentNode.level + 1));
            }

            if (currentNode.node.right != null)
            {
                toProcess.Enqueue(new TraversalNode(currentNode.node.right, currentNode.level + 1));
            }
        }

        return result;
    }


}