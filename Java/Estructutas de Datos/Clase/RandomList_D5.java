import java.util.*;
import java.util.Scanner;
public class RandomList_D5 {
    public static void main(String args[]) {
        int[] list = new int[8];
        int seed;
        int nRandom;
        System.out.println("Random Number Generator\n");
        System.out.print("Give me 9 < 100? ");
        Scanner keypad = new Scanner(System.in);
        seed = keypad.nextInt();
        for (int index = 0; index < list.length; index++) {
            nRandom = genarateRandom(seed);
            loadList(list, nRandom, index);
        }
        printList(list);
    }
    public static int genarateRandom(int s) {
        Random r = new Random();
        int nR;
        nR = r.nextInt(s);
        return nR;
    }
    public static void loadList(int[] l, int r, int i) {
        l[i] = r;
    }
    public static void printList(int[] x) {
        for (int i = 0; i < x.length; i++) {
            System.out.println(x[i]);
        }
    }
}
/*
declare list
ask seed
genarate random(seed)
loadlist(list,nr,i)
*/