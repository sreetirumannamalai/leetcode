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
    //O(max(m,n)) sc O(max(m,n))
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        if(l1 == null) return l2;
        if(l2 == null) return l1;
        
        ListNode dummyHead = new ListNode(0);
        ListNode p = l1;
        ListNode q = l2;
        ListNode curr = dummyHead;
        int carry = 0;
        while(p!=null || q != null)
        {
            int x = (p!=null) ? p.val : 0;
            int y = (q!=null) ? q.val : 0;
            int sum = x + y + carry;
            carry = sum / 10;
            curr.next = new ListNode(sum % 10);
            curr = curr.next;
            if(p != null)
                p = p.next;
            if(q != null)
                q = q.next;
        }        
        if(carry > 0)
            curr.next = new ListNode(carry);
        
        return dummyHead.next;
    }
}