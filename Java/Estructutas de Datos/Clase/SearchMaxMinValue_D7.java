import java.util.*;
import java.util.Random;
public class SearchMaxMinValue_D7 {
    public static void main(String args[]) {
        int maxvalue;
        int minvalue;
        int seed = 99;
        int[] list = new int[9];
        list = genarateRandom(list, seed);
        maxvalue = maxInt(list);
        System.out.println("Max value: " + maxvalue);
        minvalue = minInt(list);
        System.out.println("Min value: " + minvalue);
        print(list);
        String miNombre[] = { "Pedro", "Juan", "Mario", "Bob", "Rosa", "Wario" };
        Scanner keypad = new Scanner(System.in);
        int namenum;
        System.out.print("\n\nType Number for Name: ");
        namenum = keypad.nextInt();
        //int namenum = 2;
        nameSearch(miNombre, namenum);
    }
    //Generate Random
    public static int[] genarateRandom(int[] m, int s) {
        int nR;
        Random r = new Random();
        for (int i = 0; i < m.length; i++) {
            m[i] = 9 + r.nextInt(s);
        }
        return m;
    }
    //Max Value
    public static int maxInt(int[] x) {
        int max;
        max = x[0];
        for (int i = 0; i < x.length; i++) {
            if (max < x[i]) {
                max = x[i];
            }
        }
        return max;
    }
    //Min Value
    public static int minInt(int[] y) {
        int min;
        min = y[0];
        for (int i = 0; i < y.length; i++) {
            if (min > y[i]) {
                min = y[i];
            }
        }
        return min;
    }
    //Print Random list
    public static void print(int[] z) {
        System.out.print("List: ");
        for (int i = 0; i < z.length; i++) {
            System.out.print(z[i] + " ");
        }
    }

    //Search Name
    public static String nameSearch(String[] m, int n) {
        String s = "";
        System.out.print("\nCount: " + n);
        for (int i = 0; i < m.length; i++) {
            if (i == n) {
                System.out.println("\nName: " + m[i]);
            }
        }
        return s;
    }
}