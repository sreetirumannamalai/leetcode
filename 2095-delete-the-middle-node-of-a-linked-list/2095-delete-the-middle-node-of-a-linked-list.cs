/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    //O(n) sc O(1)
    public ListNode DeleteMiddle(ListNode head) {
        if(head == null || head.next == null)
            return null;
        
        ListNode fast = head;
        ListNode slow = head;
        ListNode prev = null;
        
        while(fast!=null && fast.next != null)
        {
            fast = fast.next.next;
            prev = slow;
            slow = slow.next;
        }
        
        prev.next = slow.next;
        return head;
    }
}