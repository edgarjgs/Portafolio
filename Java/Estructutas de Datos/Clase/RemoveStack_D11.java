import java.util.*;
public class RemoveStack_D11 {
    public static void main(String args[]) {
        int[] list = new int[4];
        int li = 0;
        int lf = list.length;
        int base = li - 1;
        int tope = base;
        Scanner keypad = new Scanner(System.in);
        printStack(list);
        for (int i = 0; i < list.length; i++) {
            tope = tope + 1;
            System.out.println("Data to  insert?   ");
            int num = keypad.nextInt();
            list = insertStack(list, tope, lf, num);
            printStack(list);
        }
        for (int i = 0; i < list.length; i++) {
            list = removeStack(list, tope, base);
            tope = tope - 1;
            printStack(list);
        }
    }
    public static int[] insertStack(int[] l, int top, int lf, int d) {
        if (top + 1 > lf) {
            System.out.println("Stack Full");
        } else {
            l[top] = d;
        }
        return l;
    }
    public static void printStack(int[] z) {
        System.out.println("List: ");
        for (int i = 0; i < z.length; i++) {
            System.out.println("   " + i + "   " + z[i] + " ");
        }
    }
    public static int[] removeStack(int[] n, int top, int b) {
        int dato;
        if (top == b) {
            System.out.println("Empty Stack");
        } else {
            dato = n[top];
            System.out.println("Data to delete: " + dato);
            n[top] = 0;
        }
        return n;
    }
}