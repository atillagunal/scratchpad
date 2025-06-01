 public class ListNode {
     public int val;
     public ListNode next;
     public ListNode(int val=0, ListNode next=null) {
         this.val = val;
         this.next = next;
     }
 }
 
public class SwapNodesInPairSolution {

    // swap pair starting with current node, return the head
    private ListNode Swap(ListNode current)
    {
        if (current == null)
        {
            return null;
        }

        ListNode next = current.next;

        // no need to swap if there is no next
        if (next == null)
        {
            return null;
        }

        ListNode nextsNext = next?.next;

        current.next = nextsNext;
        next.next = current;

        return next;
    }

    public ListNode SwapPairs(ListNode head)
    {
        ListNode newHead = head;
        ListNode current = head;
        ListNode prev = null;

        while (current != null)
        {
            ListNode swapped = Swap(current);

            if (swapped != null)
            {
                if (newHead == head)
                {
                    newHead = swapped;
                }
                else
                {
                    prev.next = swapped;
                }
            }

            prev = current;
            current = current.next;
        }

        return newHead;
    }
}