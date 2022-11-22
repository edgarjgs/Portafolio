//ListOperation_A18.java
// Programador: Edgar Gonzalez Serrano
// CODIGO: 512

import java.util.Scanner;
public class ListOperation_A18

{
    public static void main(String arg[]) {
        int a[] = { 30, 40, 50, 60, 70, 80 };
        int b[] = { 70, 60, 50, 40, 30, 20 };
        int c[] = new int[6];
        int longitud;
        Scanner edgar = new Scanner(System.in);

        for (int index = 0; index < a.length; index++) {
            System.out.println(a[index]);
        }

        for (int index = 0; index < b.length; index++) {
            System.out.println(b[index]);
        }

        for (int index = 0; index < c.length; index++) {
            c[index] = a[index] + b[index];
            System.out.println(a[index] + " + " + b[index] + " = " + c[index]);
        }

        System.out.print("Longitud del array ? ");
        longitud = edgar.nextInt();
        int d[] = new int[longitud];

        for (int i = 0; i < d.length; i++) {
            System.out.println("elemento para " + i);
            d[i] = edgar.nextInt();
        }
    }
}