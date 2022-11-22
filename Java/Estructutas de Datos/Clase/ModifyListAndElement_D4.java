public class ModifyListAndElement_D4 {
    public static void main(String args[]) {
        int list[] = { 5, 4, 3, 2, 1 };
        printList(list);
        modifylist(list);
        printList(list);
        int count = 2;
        modiftelemOfList(list, count);
        printList(list);
    }

    public static void printList(int[] k) {
        for (int i = 0; i < k.length; i++) {
            System.out.print(k[i] + "  ");
        }
        System.out.print("\n");
    }

    public static void modifylist(int[] x) {
        for (int i = 0; i < x.length; i++) {
            x[i] = x[i] * 10;
        }
    }

    public static void modiftelemOfList(int[] y, int z) {
        y[z] = y[z] * 8;
    }
}