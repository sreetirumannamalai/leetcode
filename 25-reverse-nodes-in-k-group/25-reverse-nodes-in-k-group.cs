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
    public ListNode ReverseKGroup(ListNode head, int k) {
        if(head == null) return head;
        
        ListNode dummy = new ListNode();
        dummy.next = head;
        ListNode prev = dummy;
        ListNode curr = dummy;
        ListNode next = null;
        while(curr != null)
        {
            for(int i=0;i<k && curr != null; i++)
                curr = curr.next;
            
            if(curr == null) break;
            
            next = curr.next;
            curr.next = null;
            
            ListNode start = prev.next;
            prev.next = Reverse(start);
            start.next = next;
            
            prev = start;
            curr = start;
        }
        return dummy.next;
    }
    
    private ListNode Reverse(ListNode head)
    {
        if(head == null || head.next == null)
        {
            return head;
        }
        ListNode prev = null;
        ListNode next = null;
        ListNode curr = head;
        while(curr != null)
        {
            next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }
        return prev;
    }
}
              
         