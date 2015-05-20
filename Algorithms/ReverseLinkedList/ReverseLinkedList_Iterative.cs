/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode ReverseList(ListNode head) {
        if (head == null || head.next == null)
            return null;

        ListNode prev;
        ListNode next;
        ListNode current = head;

        current = head;
        next = current.next;
        head.next = null;

        while (next != null)
        {
            prev = current;
            current = next;
            next = current.next;
            current.next = prev;
        }

        return current;
    }
}