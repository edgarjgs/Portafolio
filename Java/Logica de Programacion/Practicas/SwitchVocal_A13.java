//SwitchVocal_A13.java
// Programador: Edgar Gonzalez Serrano
// CODIGO: 512

import java.util.Scanner;
public class SwitchVocal_A13 {
    public static void main(String args[]) {
        char vocal;
        String data;
        Scanner edgar = new Scanner(System.in);
        System.out.print("Dame una vocal   ");
        data = edgar.next();
        vocal = data.charAt(0);

        switch (vocal) {
            case 'a':

            case 'A':

            case 'e':

            case 'E':

            case 'i':

            case 'I':

            case 'o':

            case 'O':

            case 'u':

            case 'U': {
                System.out.printf("Recibi la vocal  %c ", vocal);
                break;
            }
            default: {
                System.out.printf("%c no es vocal", vocal);
                break;
            }

        }
    }
}