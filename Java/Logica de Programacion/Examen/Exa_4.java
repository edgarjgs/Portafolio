public class Exa_4 {
    public static void main(String args[]) {
        int c = 0, s = 0, x = 25;
        double p = 0;

        while (x < 30) {
            System.out.println("number  " + x);
            x = x + 2;
            c = c + 1;
            s = s + x;
        }

        p = s / c;
        System.out.print("numbers:  " + c + "    average:  " + p);
    }
}