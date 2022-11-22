//MenorDeDos_A10.java
// Programador: Edgar Gonzalez Serrano
// CODIGO: 512

import java.util.Scanner;
public class MenorDeDos_A10 {
    public static void main(String args[]) {
        int x, y;
        Scanner edgar = new Scanner(System.in);
        System.out.print("\n Dame un valor entero x ");
        x = edgar.nextInt();
        System.out.print("\n Dame un valor entero y ");
        y = edgar.nextInt();

        if (x < y) {
            System.out.printf("\n el menor es: %d ", x);
        } else {
            System.out.printf("\n el menor es: %d ", y);
        }
    }
}