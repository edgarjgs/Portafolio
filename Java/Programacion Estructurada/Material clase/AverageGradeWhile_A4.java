import java.util.Scanner;
public class AverageGradeWhile_A4

{
    public static void main(String args[]) {
        Scanner edgarG = new Scanner(System.in);

        // set "grade" zero
        int grade = 0;

        //set "average" to zero
        int average = 0;

        //set "total" to zero
        int total = 0;

        //set "counter" to one
        int counter = 1;

        //while "counter" less than or ecual to ten
        while (counter <= 10) {
            //input "grade"
            System.out.print("Grade? ");
            grade = edgarG.nextInt();

            //add "grade" to "total"
            total = grade + total;

            //add one to "counter"
            counter = counter + 1;

        }
        //set "average" to total divided by ten
        average = total / 10;
        //print "average"
        System.out.printf("Average = %s", average);
    }
}