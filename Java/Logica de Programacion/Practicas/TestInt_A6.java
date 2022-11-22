//TestInt_A6.java
// Programador: Edgar Gonzalez Serrano
// CODIGO: 512

public class TestInt_A6 {
    public static void main(String args[]) {
        int x, y, z;
        x = 100;
        y = 300;

        z = x + y;
        System.out.printf("\n  %d  +  %d  =   %d", x, y, z);

        z = x - y;
        System.out.printf("\n  %d  -  %d  =   %d", x, y, z);

        z = x * y;
        System.out.printf("\n  %d  *  %d  =   %d", x, y, z);

        z = x / y;
        System.out.printf("\n  %d  /  %d  =   %d", x, y, z);

        z = y / x;
        System.out.printf("\n  %d  /  %d  =   %d", x, y, z);
    }
}