import java.util.Scanner;
public class AverageGradeFor_A5 {
    public static void main(String args[]) {
        Scanner edgarG = new Scanner(System.in);

        // set "grade" zero
        int grade = 0;

        //set "average" to zero
        int average = 0;

        //set "total" to zero
        int total = 0;

        //for (set "count" to one; "count" less than or ecual to ten; add one to "total")
        for (int count = 1; count <= 10; count++) {
            //input "grade"
            System.out.print("Grade? ");
            grade = edgarG.nextInt();

            //add "grade" to "total"
            total = grade + total;
        }

        //set "average" to "total" divided by ten
        average = total / 10;
        //print "average"
        System.out.printf("Average = %s", average);
    }
}