/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        if (head == null || head.next == null)
            return head;
        
        ListNode current = head;

        while (current != null) 
        {
            while (current.next != null && current.val == current.next.val)
            {
                if(current.next.next != null)
                {
                    current.next = current.next.next;
                }
                else
                {
                    current.next = null;
                    break;
                }
            }
            current = current.next;
        }
        
        return head;
    }
}