import java.util.Scanner;
public class StudentGrad_A1

{
    public static void main(String args[]) {
        //nombrar scanner
        Scanner edgar;

        //iniciar nuevo scanner
        edgar = new Scanner(System.in);

        //nombrar string "name" y int "grade"
        String name;
        int grade;

        //imprimir "name"
        System.out.print("Name ? ");

        //pedir al usuario que escriba y guardar el resultado en "name"
        name = edgar.next();

        //imprimir "grade"
        System.out.print("Grade ? ");

        //pedir al usuario que escriba y guardar el resultado en "grade"
        grade = edgar.nextInt();

        //structura if "grade" es mayor de 60
        if (grade >= 60) {
            //imprimir lo que "name" tenga guardado
            System.out.printf("%s ", name);
            //print passed   
            System.out.print("Passed");
        }
    }
}