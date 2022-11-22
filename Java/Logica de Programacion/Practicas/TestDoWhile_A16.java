//TestDoWhile_A16.java
// Programador: Edgar Gonzalez Serrano
// CODIGO: 512

import java.util.Scanner;
public class TestDoWhile_A16 {
    public static void main(String args[]) {
        int i = 1, n, t;
        Scanner edgar = new Scanner(System.in);

        do {
            System.out.println(i);
            i = i + 1;
        }
        while (i < 100);

        System.out.println("\n\n\n");
        System.out.println("Dame valor inicial");
        n = edgar.nextInt();
        System.out.println("Dame valor final");
        t = edgar.nextInt();

        System.out.println("\n\n Aqui ejecuta while... ");
        do {
            System.out.println(n);
            n = n + 1;
        }
        while (n < t);
    }
}