//characteristicas
class ListNode {
    Object data;
    ListNode nextNode;
    ListNode(Object object) {
        this(object, null);
    }
    ListNode(Object object, ListNode node) {
        data = object;
        nextNode = node;
    }
}