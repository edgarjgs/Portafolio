//Alg_MenorDeTres_A11.java
// Programador: Edgar Gonzalez Serrano
// CODIGO: 512

import java.util.Scanner;
public class Alg_MenorDeTres_A11 {
    public static void main(String args[]) {
        int x, y, z;
        Scanner edgar = new Scanner(System.in);
        System.out.print("\n Dame un valor entero x ");
        x = edgar.nextInt();
        System.out.print("\n Dame un valor entero y ");
        y = edgar.nextInt();
        System.out.print("\n Dame un valor entero z ");
        z = edgar.nextInt();

        if (x < y) {
            if (x < z) {
                System.out.printf("\n el menor es: %d ", x);
            } else {
                System.out.printf("\n el menor es: %d ", z);
            }
        } else {
            if (y < z) {
                System.out.printf("\n el menor es: %d ", y);
            } else {
                System.out.printf("\n el menor es: %d ", z);
            }
        }
    }
}