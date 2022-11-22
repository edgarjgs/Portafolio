import java.io.*;
public class CreateFileASCII_A9 {
    public static void main(String args[]) {
        //este programa imprime characteres y su correspondiente numero de ASCII y guarda el resultado en un .txt file
        //initialize variable
        //set file name to edgar307
        String fileName = "D:\\uni\\enero-mayo 2018\\structured programing\\programs\\2018 enero\\MyFiles2315\\egonzalez307Ascii_A9.txt";

        //iniciar variables "min", "max", "character" y "codeAscii"
        char min, max, character;
        int codeAscii;

        min = 32;
        max = 254;
        character = min;
        codeAscii = min;

        //crear file
        try {
            //iniciar FileWriter
            FileWriter edgarG = new FileWriter(fileName);

            //write in file 
            //si "character" es menor que "max" corre sino ignora 
            while (character < max) {
                //imprime character y su correspondiente numero de ascii en .txt
                edgarG.write(character + "  " + codeAscii + "\r\t");
                //character = character + 1;
                character++;
                //guardar valor de "character" en "codeAscii"
                codeAscii = character;
                edgarG.flush();

                //brincar una linea en el .txt (next line)  
                edgarG.write(System.lineSeparator());
            }
            //escribir en el final del achivo
            edgarG.write("Student name: Edgar Gonzalez Serrano. code: 307, 03/06/2018");
            //cerrar file
            edgarG.close();
        }

        //en caso de que la localizacion del .txt sea invalida
        catch (IOException e) {
            System.out.print("imposible to create" + fileName);
        }
    }
}