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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        // Initialize a dummy node to serve as the starting point of the result list
        ListNode dummyHead = new ListNode(0);
        ListNode current = dummyHead;
        int carry = 0;

        // Loop through lists l1 and l2 until you reach both ends, also considering the carry
        while (l1 != null || l2 != null)
        {
            // Get the current values (or 0 if one list is shorter)
            int x = (l1 != null) ? l1.val : 0;
            int y = (l2 != null) ? l2.val : 0;

            // Calculate the sum of the current digits plus carry
            int total = carry + x + y;

            // Update carry for next calculations
            carry = total / 10;

            // Create a new node with the digit value of the total mod 10 and set it as the next of the current node
            current.next = new ListNode(total % 10);

            // Move the current node to the next
            current = current.next;

            // Move to the next nodes in l1 and l2
            if (l1 != null) l1 = l1.next;
            if (l2 != null) l2 = l2.next;
        }

        // If there's any carry left after the loop, add it as a new node
        if (carry > 0)
        {
            current.next = new ListNode(carry);
        }

        // Return the next node of the dummy head which is the actual start of the result list
        return dummyHead.next;
    }
}
