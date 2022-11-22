import java.util.Scanner;
public class SentinelaCompras_A11 {
    public static void main(String args[]) {
        //set "compra" = 0; set "total" = 0
        double compra = 0.0;
        double total = 0.0;

        //iniciar scanner
        Scanner edgarG = new Scanner(System.in);

        //prompt user to enter compra y guardar resultado en "compra"
        System.out.print("Valor de la compra?");
        compra = edgarG.nextDouble();

        //suma de "total" y "compra" guardado en "total"
        total = total + compra;

        while (compra != -1.0) //sentinela es compra
        {
            //imprimir valor en "total" 
            System.out.println("total = " + total);
            //suma de "total" y "compra" guardado en "total"
            total = total + compra;
            //prompt user to enter compra y guardar resultado en "compra"
            System.out.print("Valor de la compra?");
            compra = edgarG.nextDouble();

        }
    }
}