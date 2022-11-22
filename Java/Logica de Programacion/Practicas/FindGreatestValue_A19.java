//FindGreatestValue_A19.java
// Programador: Edgar Gonzalez Serrano
// CODIGO: 512

import java.util.Scanner;
public class FindGreatestValue_A19

{
    public static void main(String arg[]) {
        int mayor = 0, size = 0, index = 0, menor = 0;
        int a[] = { 100, 200, 500, 1000, 1500 };

        mayor = a[0];
        size = a.length;
        index = index + 1;

        // mayor
        while (index < size) {
            if (mayor < a[index]) {
                mayor = a[index];
            }
            index = index + 1;

        }

        System.out.println("a[]");
        for (int i = 0; i < size; i = i + 1) {
            System.out.println(a[i]);
        }
        System.out.println("Mayor: " + mayor);

        // menor

        index = 0;
        menor = a[0];

        while (index < size) {
            if (menor > a[index]) {
                menor = a[index];
            }
            index = index + 1;
        }

        System.out.println("a[]");
        for (int i = 0; i < size; i = i + 1) {
            System.out.println(a[i]);
        }
        System.out.println("Menor: " + menor);
    }
}