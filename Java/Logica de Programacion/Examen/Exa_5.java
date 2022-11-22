public class Exa_5 {
    public static void main(String args[]) {
        int mony = 100;
        do {
            System.out.println("Hay " + mony);
            mony = mony - 20;
        }
        while (mony > 0);
        System.out.println("Quedo " + mony);
    }
}