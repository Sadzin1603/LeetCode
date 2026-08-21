public class AddTwoNumbers {
    
    class ListNode {
        int val;
        ListNode next;
        ListNode() {}
        ListNode(int val) { this.val = val; }
        ListNode(int val, ListNode next) { this.val = val; this.next = next; }
    }

    public ListNode addTwoNumbers(ListNode l1, ListNode l2) {
        
        ListNode head = new ListNode(0);
        ListNode current = head;
        int carry=0;

        while (l1!=null || l2 !=null || carry>0){
            int v1;
            int v2;
            if(l1!=null){
                v1=l1.val;
            }else{
                v1=0;
            }

            if(l2!=null){
                v2=l2.val;
            }else{
                v2=0;
            }
            int soma = v1+v2+carry;
            int digito = soma%10;
            carry = soma / 10;

            current.next = new ListNode(digito);
            current = current.next;

            l1 = l1.next;
            l2 = l2.next;
        }
        return head.next;

    }

}
