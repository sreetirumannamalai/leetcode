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
        if(head == null) return null;
        
        ListNode dummy = new ListNode();
        dummy.next = head;
        
        ListNode current = dummy;
        ListNode previous = dummy;
        ListNode next = null;
        while(current != null)
        {
            for(int i=0;i<k && current !=null ;i++)
                current = current.next;
            
            if(current == null)
                break;
            
            next = current.next;
            current.next = null;
            
            ListNode start = previous.next;
            previous.next = Reverse(start);
            start.next = next;
            
            previous = start;
            current = start;
        }
        
        return dummy.next;
    }
    
    public ListNode Reverse(ListNode head)
    {
        if(head == null)
            return null;
        
        ListNode current = head;
        ListNode previous = null;
        
        while(current != null)
        {
            ListNode temp = current.next;
            current.next = previous;
            previous = current;
            current = temp;
        }
        return previous;
    }
}