/*
ValidateBinarySearchFastSolution solution = new ValidateBinarySearchFastSolution();

TreeNode leftNode = new TreeNode(1);
TreeNode rightNode = new TreeNode(3);
TreeNode rootNode = new TreeNode(2, leftNode, rightNode);

Console.WriteLine(solution.IsValidBST(rootNode));

rightNode.val = 0;
Console.WriteLine(solution.IsValidBST(rootNode));
*/

/*
BinaryTreeLevelOrderSolution solution = new BinaryTreeLevelOrderSolution();

TreeNode leftNode = new TreeNode(1);
TreeNode rightNode = new TreeNode(3);
TreeNode rootNode = new TreeNode(2, leftNode, rightNode);

var result = solution.LevelOrder(rootNode);

Console.WriteLine(string.Join(';', result.Select(e => string.Join(',', e))));
*/

/*
KthLargestElementSolution solution = new KthLargestElementSolution();

int[] array = [3,2,1,5,6,4];

Console.WriteLine(solution.FindKthLargest(array, 2));
*/

/*
LongestValidParanthesisSolution solution = new LongestValidParanthesisSolution();
Console.WriteLine(solution.LongestValidParentheses("()(())"));

Console.WriteLine(solution.LongestValidParentheses("()()())))"));
Console.WriteLine(solution.LongestValidParentheses("()()())))()"));
Console.WriteLine(solution.LongestValidParentheses("())(())"));
Console.WriteLine(solution.LongestValidParentheses("()()())))(((())))"));
Console.WriteLine(solution.LongestValidParentheses("(()()"));
*/

/*
using System.Diagnostics;

SwapNodesInPairSolution solution = new SwapNodesInPairSolution();
Debug.Assert(solution.SwapPairs(null) == null, "failed: solution.Swap(null) == null check");

ListNode node4 = new ListNode(4, null);
ListNode node3 = new ListNode(3, node4);
ListNode node2 = new ListNode(2, node3);
ListNode node1 = new ListNode(1, node2);

ListNode newHead = solution.SwapPairs(node1);

Debug.Assert(newHead == node2,    "failed: newHead == node2 check");
Debug.Assert(node2.next == node1, "failed: node2.next == node1 check");
Debug.Assert(node1.next == node4, "failed: node1.next == node4 check");
Debug.Assert(node4.next == node3, "failed: node4.next == node3 check");
Debug.Assert(node3.next == null, "failed: node3.next == null check");

Console.WriteLine("all checks passed!!");
*/

/*
BinarySearch binarySearch = new BinarySearch();
int[] array = [2, 4, 6, 8];
Console.WriteLine($"binarySearch.Search(array, 1): {binarySearch.Search(array, 1)}");
Console.WriteLine($"binarySearch.Search(array, 2): {binarySearch.Search(array, 2)}");
Console.WriteLine($"binarySearch.Search(array, 3): {binarySearch.Search(array, 3)}");
Console.WriteLine($"binarySearch.Search(array, 4): {binarySearch.Search(array, 4)}");
Console.WriteLine($"binarySearch.Search(array, 5): {binarySearch.Search(array, 5)}");
Console.WriteLine($"binarySearch.Search(array, 6): {binarySearch.Search(array, 6)}");
Console.WriteLine($"binarySearch.Search(array, 7): {binarySearch.Search(array, 7)}");
Console.WriteLine($"binarySearch.Search(array, 8): {binarySearch.Search(array, 8)}");
Console.WriteLine($"binarySearch.Search(array, 9): {binarySearch.Search(array, 9)}");
*/

/*
using System.Diagnostics;

BinarySearchTreeSolution solution = new BinarySearchTreeSolution();

TreeNode leftNode = new TreeNode(1);
TreeNode rightNode = new TreeNode(3);
TreeNode rootNode = new TreeNode(2, leftNode, rightNode);

Debug.Assert(solution.SearchBST(rootNode, 1) == leftNode);
Debug.Assert(solution.SearchBST(rootNode, 3) == rightNode);
Debug.Assert(solution.SearchBST(rootNode, 2) == rootNode);
Debug.Assert(solution.SearchBST(rootNode, 0) == null);
Debug.Assert(solution.SearchBST(rootNode, 4) == null);
Debug.Assert(solution.SearchBST(rootNode, 5) == null);

Console.WriteLine("all checks passed");
*/

/*
using System.Diagnostics;

BinarySearchTreeSolution solution = new BinarySearchTreeSolution();

TreeNode leftNode = new TreeNode(1);
TreeNode rightNode = new TreeNode(3);
TreeNode rootNode = new TreeNode(2, leftNode, rightNode);

Debug.Assert(solution.SearchBSTStack(rootNode, 1) == leftNode);
Debug.Assert(solution.SearchBSTStack(rootNode, 3) == rightNode);
Debug.Assert(solution.SearchBSTStack(rootNode, 2) == rootNode);
Debug.Assert(solution.SearchBSTStack(rootNode, 0) == null);
Debug.Assert(solution.SearchBSTStack(rootNode, 4) == null);
Debug.Assert(solution.SearchBSTStack(rootNode, 5) == null);

Console.WriteLine("all checks passed");
*/

/*
MaxIslandAreaSolution solution = new MaxIslandAreaSolution();

int[][] grid = new int[2][];
grid[0] = new int[] { 1, 1, 1, 0 };
grid[1] = new int[] { 0, 1, 1, 1 };

Console.WriteLine(solution.MaxAreaOfIsland(grid));
*/

/*
DetectCyclesIn2DGridSolution solution = new DetectCyclesIn2DGridSolution();
char[][] grid = [ ['a', 'b', 'a', 'a'],
                  ['a', 'b', 'b', 'a'],
                  ['a', 'b', 'c', 'a'],
                  ['a', 'a', 'a', 'a']];

Console.WriteLine(solution.ContainsCycle(grid));
*/

ConvertArrayTo2dSolution solution = new ConvertArrayTo2dSolution();
var result = solution.FindMatrix([1, 2, 3, 4, 2, 3, 4, 3, 4, 1]);
Console.WriteLine(string.Join("\n", result.Select(l => string.Join(",", l))));
