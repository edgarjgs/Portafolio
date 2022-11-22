import java.util.Scanner;
import java.io.*;
public class CreateMaria_A10

{
    public static void main(String args[]) {
        //el programa guardara lo que el usuario le escriba en la consola en un .txt

        //iniciar "count", "palabra" y "fileName"
        int count = 1;
        String palabra;
        String fileName = "D:\\uni\\enero-mayo 2018\\structured programing\\programs\\2018 enero\\MyFiles2315\\maria_A10.txt";

        //iniciar Scanner
        Scanner edgarG = new Scanner(System.in);
        try {

            //iniciar FileWriter
            FileWriter egs = new FileWriter(fileName);

            //imprimir en la consola
            System.out.print("Dime tu experiencia durante el Huracan Maria? ");

            //guardar resultado dado por el usuario en "palabra"
            palabra = edgarG.nextLine();

            // guardar resultado en palabra en el .txt
            egs.write(palabra + " ");

            //brincar una linea en el .txt (next line) 
            egs.write(System.lineSeparator());

            //correr mientras que "count" sea menor que 7
            while (count < 7) {
                //imprimir en la consola
                System.out.print("Dime tu experiencia durante el Huracan Maria? ");

                //guardar resultado dado por el usuario en "palabra"
                palabra = edgarG.nextLine();

                //guardar resultado en palabra en el .txt
                egs.write(palabra + " ");

                //añadir +1 a "count"
                count++;

                //brincar una linea en el .txt (next line) 
                egs.write(System.lineSeparator());
            }
            //escribir en el .txt
            egs.write("Student name: Edgar Gonzalez Serrano. code: 307, 03/20/2018");

            //imprimir done printing en la consola
            System.out.print("Done printing");

            //cerrar file
            egs.close();
        }
        //en caso de que la localizacion del .txt sea invalida   
        catch (IOException e) {
            System.out.print("imposible to create" + fileName);
        }
    }
}