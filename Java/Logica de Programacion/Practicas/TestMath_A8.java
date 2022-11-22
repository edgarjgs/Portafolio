//TestMath_A8.java
// Programador: Edgar Gonzalez Serrano
// CODIGO: 512

import java.util.Scanner;
public class TestMath_A8 {
    public static void main(String args[]) {
        double a, b, c, r, PI, areaCirculo;
        PI = 3.1416;
        Scanner edgar = new Scanner(System.in);
        //triangulo
        System.out.print("Hipotenusa del triangulo \n \n");
        System.out.print("Dame base?  ");
        b = edgar.nextDouble();
        System.out.print("Dame altura?  ");
        a = edgar.nextDouble();
        c = Math.sqrt(Math.pow(a, 2) + Math.pow(b, 2));
        System.out.printf("\n\nHipotenusa es : %f \n\n", c);
        //circulo
        System.out.print("Area del circulo \n \n");
        System.out.print("Dame radio?  ");
        r = edgar.nextDouble();
        areaCirculo = PI * Math.pow(r, 2);
        System.out.printf("\nArea es %f", areaCirculo);
    }
}