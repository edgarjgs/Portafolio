import java.io.*;
public class ReadTestSecuential_A12 {
    public static void main(String args[]) {
        //set "fn" to name.txt
        String fileName = "D:/uni/enero-mayo 2018/structured programing/programs/2018 enero/MyFiles2315/egonzalez307Ascii_A9.txt";
        //set "dato" to zero  
        int dato = 0;

        //open file     
        try {
            FileReader egs = new FileReader(fileName);
            //lee "dato"
            dato = egs.read();

            //while("dato" is not file ending)
            while (dato != -1.0) //sentinela es "dato"
            {
                //print "dato"
                System.out.print((char) dato);
                //lee "dato"
                dato = egs.read();
            }
            //close file
            egs.close();

            //imprimir en el final de la consola
            System.out.print("\nStudent name: Edgar Gonzalez Serrano. code: 307");

        }
        //en caso de que la localizacion del .txt sea invalida
        catch (IOException e) {
            System.out.print("imposible to read " + fileName);
        }
    }
}