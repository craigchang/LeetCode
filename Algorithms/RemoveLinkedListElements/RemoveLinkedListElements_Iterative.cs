/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode RemoveElements(ListNode head, int val) {
        if (head == null)
                return null;

        while (head != null)
        {
            if (head.val == val)
                head = head.next;
            else
                break;
        }

        ListNode prev = head;
        
        if (head == null)
                return null;
        
        ListNode current = head.next;

        while (current != null)
        {
            if (current.val == val) // found
            {
                prev.next = current.next;
                current = current.next;
            }
            else // not found
            {
                prev = current;
                current = current.next;
            }
        }

        return head;
    }
}