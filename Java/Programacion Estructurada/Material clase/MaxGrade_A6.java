import java.util.Scanner;
public class MaxGrade_A6

{
    public static void main(String args[]) {
        Scanner edgarG = new Scanner(System.in);

        // set "grade" zero
        int grade = 0;

        //set "maxGrade" to zero
        int maxGrade = 0;

        //set "count" to zero
        int count = 1;

        //prompt user to enter grade and save result in "grade"
        System.out.print("Grade? ");
        grade = edgarG.nextInt();

        //turn value from "grade" and add it to "maxGrade"
        maxGrade = grade;

        while (count <= 10) {
            //prompt user to enter grade and save result in "grade"
            System.out.print("Grade? ");
            grade = edgarG.nextInt();

            //if "grade" is bigger than "maxGrade" run if not ignore
            if (grade > maxGrade) {
                maxGrade = grade;
            }
            //add one to "count"
            count = count + 1;
        }
        //print "maxGrade"
        System.out.printf("Max grade = %s", maxGrade);
    }
}