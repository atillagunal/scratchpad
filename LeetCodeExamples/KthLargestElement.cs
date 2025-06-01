public class KthLargestElementSolution
{
    public int FindKthLargest(int[] nums, int k)
    {
        // add all numbers into a priority queue O(n)
        PriorityQueue<int, int> pQueue = new PriorityQueue<int, int>();

        for (int i = 0; i < nums.Length; ++i)
        {
            pQueue.Enqueue(nums[i], -1 * nums[i]);
        }

        // get kth element from queue kO(logn)
        int kthLargest = 0;

        while (k-- > 0)
        {
            kthLargest = pQueue.Dequeue();
        }

        return kthLargest;
    }
}