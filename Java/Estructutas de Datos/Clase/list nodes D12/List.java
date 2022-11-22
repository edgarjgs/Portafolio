public class List {
    private ListNode firstNode;
    private ListNode lastNode;
    private String name;
    public List() {
        this("Lista_A");
    }
    public List(String listName) {
        name = listName;
        lastNode = null;
        lastNode = firstNode;
    }
    public void insertAtFront(Object insertItem) {
        if (isEmpty()) {
            lastNode = new ListNode(insertItem);
            lastNode = firstNode;
        } else {
            firstNode = new ListNode(insertItem, firstNode);
        }
    }


    public void insertAtBack(Object insertItem) {
        if (isEmpty()) {
            lastNode = new ListNode(insertItem);
            firstNode = lastNode;
        } else {
            lastNode.nextNode = new ListNode(insertItem);
            lastNode = lastNode.nextNode;
        }
    }


    public Object removeFromFront() throws EmptyListException {
        if (isEmpty()) {
            throw new EmptyListException(name);
        } else {
            Object removedItem = firstNode.data;
            if (firstNode == lastNode) {
                firstNode = lastNode = null;
            } else {
                firstNode = firstNode.nextNode;
            }
            return removedItem;
        }
    }
    public Object removeFromBack() throws EmptyListException {
        if (isEmpty()) {
            throw new EmptyListException(name);
        } else {
            Object removedItem = lastNode.data;
            if (firstNode == lastNode) {
                firstNode = lastNode = null;
            } else {
                ListNode current = firstNode;
                while (current.nextNode != lastNode) {
                    current = current.nextNode;
                }
                lastNode = current;
                current.nextNode = null;
            }
            return removedItem;
        }
    }
    public boolean isEmpty() {
        boolean empty;
        empty = (firstNode == null);
        return empty;
    }

    public void printList() {
        if (isEmpty()) {
            System.out.println("Empty     " + name);
            return;
        }
        System.out.println("The list is:  " + name);
        ListNode current = firstNode;
        while (current != null) {
            System.out.println(current.data);
            current = current.nextNode;
        }
    }
}