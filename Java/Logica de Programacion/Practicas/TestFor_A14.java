//TestFor_A14.java
// Programador: Edgar Gonzalez Serrano
// CODIGO: 512

import java.util.Scanner;
public class TestFor_A14 {
    public static void main(String args[]) {
        int n, t;
        Scanner edgar = new Scanner(System.in);

        for (int i = 1; i <= 6000; i = i + 1) {
            System.out.println(i);
        }

        System.out.println("Dame valor inicial   ");
        n = edgar.nextInt();
        System.out.println("Dame valor final   ");
        t = edgar.nextInt();

        for (int k = n; k <= t; k = k + 1) {
            System.out.println(k);
        }
    }
}