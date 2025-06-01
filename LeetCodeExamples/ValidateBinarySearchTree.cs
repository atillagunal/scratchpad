

public class TreeNode
{
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
          this.val = val;
          this.left = left;
          this.right = right;
      }
  }

public class MinMax
{
    public int min;
    public int max;
}

public class ValidateBinarySearchSolution
{
    public bool IsValidBST(TreeNode root)
    {
        Dictionary<TreeNode, MinMax> minmaxMap = new Dictionary<TreeNode, MinMax>();

        GenerateMinMaxMap(root, minmaxMap);

        return IsValidBSTRecursion(root, minmaxMap);
    }

    private void GenerateMinMaxMap(TreeNode node, Dictionary<TreeNode, MinMax> minmaxMap)
    {
        if (node == null)
        {
            return;
        }

        GenerateMinMaxMap(node.left, minmaxMap);
        GenerateMinMaxMap(node.right, minmaxMap);

        int minVal = 0, maxVal = 0;
        if (node.left != null && node.right != null)
        {
            minVal = Math.Min(Math.Min(node.val, minmaxMap[node.left].min), minmaxMap[node.right].min);
            maxVal = Math.Max(Math.Max(node.val, minmaxMap[node.left].max), minmaxMap[node.right].max);
        }
        else if (node.left != null)
        {
            minVal = Math.Min(node.val, minmaxMap[node.left].min);
            maxVal = Math.Max(node.val, minmaxMap[node.left].max);
        }
        else if (node.right != null)
        {
            minVal = Math.Min(node.val, minmaxMap[node.right].min);
            maxVal = Math.Max(node.val, minmaxMap[node.right].max);
        }
        else
        {
            minVal = node.val;
            maxVal = node.val;
        }

        minmaxMap.Add(node, new MinMax() { min = minVal, max = maxVal });
    }

    public bool IsValidBSTRecursion(TreeNode root, Dictionary<TreeNode, MinMax> minmaxMap)
    {
        if (root == null)
        {
            return true;
        }

        return (root.left != null && minmaxMap[root.left].max < root.val || root.left == null) &&
                   (root.right != null && minmaxMap[root.right].min > root.val || root.right == null) &&
                   IsValidBSTRecursion(root.left, minmaxMap) &&
                   IsValidBSTRecursion(root.right, minmaxMap);
    }
}

