import java.util.*;
public class Selection_Sort_D9 {
    public static void main(String args[]) {
        //crear list
        int[] list = { 9, 7, 5, 4, 3, 0 };
        //print list
        print(list);
        //sort
        selectionSort(list);
        //print(list);
    }
    //sort
    public static void selectionSort(int n[]) {
        for (int i = 0; i < n.length; i++) {
            int lowValue = n[i];
            for (int k = i + 1; k < n.length; k++) {
                if (n[k] < lowValue) {
                    lowValue = n[k];
                    swap(n, i, k);
                }
            }
        }
    }
    public static void swap(int m[], int first, int second) {
        int temp = m[first];
        m[first] = m[second];
        m[second] = temp;
        print(m);
    }
    public static void print(int[] p) {
        for (int z = 0; z < p.length; z++) {
            System.out.print(p[z]);
        }
        System.out.println("");
    }
}