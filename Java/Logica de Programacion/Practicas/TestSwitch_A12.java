//TestSwitch_A12.java
// Programador: Edgar Gonzalez Serrano
// CODIGO: 512

import java.util.Scanner;
public class TestSwitch_A12 {
    public static void main(String args[]) {
        int number;
        Scanner edgar = new Scanner(System.in);
        System.out.print("Dame 1, 2 o 3  ");
        number = edgar.nextInt();

        switch (number) {
            case 1: {
                System.out.printf("recibi %d", number);
                break;
            }
            case 2: {
                System.out.printf("recibi %d", number);
                break;
            }
            case 3: {
                System.out.printf("recibi %d", number);
                break;
            }
            default: {
                System.out.printf("\n%d no es 1, 2 o 3", number);
                break;
            }
        }
    }
}