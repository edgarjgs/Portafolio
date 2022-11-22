import java.util.Scanner;
public class StudentGrade_A3

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

        // structura if "grade" es mayor que 90 sino inicia else
        if (grade >= 90) {
            //imprimir valor que "name" tenga guardado 
            System.out.printf("%s ", name);
            //imprimir A y el valor en "grade"
            System.out.printf("A %s", grade);
        } else {

            // structura if "grade" es mayor que 80 sino inicia else
            if (grade >= 80) {
                //imprimir valor que "name" tenga guardado  
                System.out.printf("%s ", name);
                //imprimir B y el valor en "grade"
                System.out.printf("B %s", grade);
            } else {

                // structura if "grade" es mayor que 70 sino inicia else 
                if (grade >= 70) {
                    //imprimir valor que "name" tenga guardado 
                    System.out.printf("%s ", name);
                    //imprimir C y el valor en "grade"
                    System.out.printf("C %s", grade);
                } else {
                    // structura if "grade" es mayor que 60 sino inicia else 
                    if (grade >= 60) {
                        //imprimir valor que "name" tenga guardado  
                        System.out.printf("%s ", name);
                        //imprimir D y el valor en "grade"
                        System.out.printf("D %s", grade);
                    } else {
                        //imprimir valor que "name" tenga guardado  
                        System.out.printf("%s ", name);
                        //imprimir F y el valor en "grade"
                        System.out.printf("F %s", grade);
                    }
                }
            }
        }
    }
}