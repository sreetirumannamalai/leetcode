/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    //O(n) sc O(1)
    public Node CopyRandomList(Node head) {
        Node current = head;
        //1. copy node and insert after actual nodes
        while(current!=null)
        {
            Node copy = new Node(current.val);
            copy.next = current.next;
            current.next = copy;
            current = current.next.next;
        }
        //2. map random pointer
        current = head;
        while(current != null)
        {
            current.next.random = current.random == null ? null : current.random.next;
            current = current.next.next;
        }
        
        //3. extract copy node
        Node dummyhead = new Node(-1);
        Node dummy = dummyhead;
        current = head;
        while(current != null)
        {
            dummy.next = current.next;
            dummy = dummy.next;
            current.next = current.next.next;
            current = current.next;
        }
        return dummyhead.next;
    }
}
  