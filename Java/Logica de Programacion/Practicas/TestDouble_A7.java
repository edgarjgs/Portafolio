//TestDouble_A7.java
// Programador: Edgar Gonzalez Serrano
// CODIGO: 512

import java.util.Scanner;
public class TestDouble_A7 {
    public static void main(String args[]) {
        double x, y, r;
        x = 99.99;
        y = 199.99;
        r = x + y;
        System.out.printf("\n %f + %f = %f", x, y, r);
        r = x - y;
        System.out.printf("\n %10.5f - %10.5f = %8.2f", x, y, r);

        double a = 0;
        double b = 0;

        Scanner edgar = new Scanner(System.in);

        System.out.print("\n \n dame valor para a? ");
        a = edgar.nextDouble();

        System.out.print("\n \n dame valor para b? ");
        b = edgar.nextDouble();

        r = 2 + a / 4 * b - 10;
        System.out.printf("\n 2 + %f /4 * %f - 10 = %f", a, b, r);
    }
}