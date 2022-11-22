//TestString_A5.java
// Programador: Edgar Gonzalez Serrano
// CODIGO: 512.


import java.util.Scanner;
public class TestString_A5 {
    public static void main(String args[]) {
        String s1 = "comp  ", s2 = "2120";
        String s3 = "Edgar", s4 = "512";
        System.out.print(s1);
        System.out.println(s2);
        System.out.printf("%s %s\n\n", s3, s4);
        System.out.println(s1 + s2);


        Scanner edgar = new Scanner(System.in);
        System.out.print("Dame tu nombre --> ");
        s1 = edgar.nextLine();
        System.out.printf("Gracias %s", s1);
    }
}