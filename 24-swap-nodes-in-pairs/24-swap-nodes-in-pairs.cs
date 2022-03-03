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
    public ListNode SwapPairs(ListNode head) {
        //Dummy node acts as the prevNode for the head node
        //of the list and hence stores pointer to the head node
        ListNode dummy = new ListNode();
        dummy.next = head;
        ListNode prevNode = dummy;
        while((head != null) && (head.next != null))
        {
            //nodes to be swapped
            ListNode firstNode = head;
            ListNode secondNode = head.next;
            
            //swapping
            prevNode.next = secondNode;
            firstNode.next = secondNode.next;
            secondNode.next = firstNode;
            
            //Reinitializing the head and prevNode for next swap
            prevNode = firstNode;
            head = firstNode.next;
        }
        //return the new head node
        return dummy.next;
    }
}