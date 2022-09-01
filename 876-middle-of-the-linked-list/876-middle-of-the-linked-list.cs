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
    //TC O(N) sc O(1)
    public ListNode MiddleNode(ListNode head) {
        ListNode middle = head;
        ListNode end = head;
        while(end != null && end.next != null)
        {
            middle = middle.next;
            end = end.next.next;
        }
        return middle;
    }
}