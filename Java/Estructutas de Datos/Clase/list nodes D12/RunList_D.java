class RunList_D {
    public static void main(String args[]) {
        int k = 10;
        List a = new List("Lista_A");
        List b = new List("Lista_B");
        for (int i = 1; i <= 10; i = i + 1) {
            if (i % 2 == 0) {
                a.insertAtFront(k * i - 9);
            } else {
                b.insertAtBack(9 * k * i);
            }
        }
        a.printList();
        b.printList();
    }
}