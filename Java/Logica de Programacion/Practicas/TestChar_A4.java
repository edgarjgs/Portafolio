//TestChar_A4.java
// Programador: Edgar Gonzalez Serrano
// CODIGO: 512.

public class TestChar_A4 {
    public static void main(String args[]) {
        char c = 'C';
        char o = 'o', m = 'm', p = 'p';
        char dos = '2', uno = '1', cero = '0';
        char nine = '9', four = '4';
        char i = 'i', d = 'd', g = 'g';



        System.out.println(c + "\n" + o + "\n" + m + "\n" + p);
        System.out.println(dos + "\n" + uno + "\n" + dos + "\n" + cero);
        System.out.println(c + o + m + p);
        System.out.println(dos + uno + dos + cero);

        System.out.print("\n\nImprime con  formato \n");
        System.out.printf("%C%C%C%C%C%C ", c, o, d, i, g, o);
        System.out.printf("%c ", nine);
        System.out.printf("%c ", four);
        System.out.printf("%c ", nine);
    }
}