import java.util.Scanner;
public class StudentGrad_A2

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

        //pedir al usuario que escriba y guardar el resultado el "name"
        name = edgar.next();

        //imprimir "grade"
        System.out.print("Grade ? ");

        //pedir al usuario que escriba y guardar el resultado el "grade"
        grade = edgar.nextInt();

        // structura if "grade" mayor que 60
        if (grade >= 60) {
            //imprimir lo que "name" tenga guardado
            System.out.printf("%s ", name);

            //print passed 
            System.out.print("Passed");
        } else {
            //imprimir lo que "name" tenga guardado y failed
            System.out.printf("%s Failed", name);
        }
    }
}