public class Exa_3 {
    public static void main(String args[]) {
        int sum = 0, count = 0;
        double average = 0;
        for (int value = 105; value > 100; value = -2) {
            sum = sum + value;
            count = count + 1;
            System.out.println(count + "  es  " + value);
        }
        average = sum / count;
        System.out.print(sum + "   average:   " + average);
    }
}