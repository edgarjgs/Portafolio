//Testwhile_A15.java
// Programador: Edgar Gonzalez Serrano
// CODIGO: 512

import java.util.Scanner;
public class TestWhile_A15

{
    public static void main(String args[]) {
        int i = 1, n, t;
        Scanner edgar = new Scanner(System.in);

        while (i <= 99) {
            System.out.println(i);
            i = i + 1;
        }
        System.out.println("\n\n\n");
        System.out.println("dame valor inicial");
        n = edgar.nextInt();
        System.out.println("dame valor final");
        t = edgar.nextInt();
        System.out.println("\n\n Aqui ejecuta while ");
        while (n <= t) {
            System.out.println(n);
            n = n + 1;
        }
    }
}