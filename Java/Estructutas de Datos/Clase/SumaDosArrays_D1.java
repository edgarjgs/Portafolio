public class SumaDosArrays_D1 {
    public static void main(String args[]) {
        int x[] = new int[5];
        //int x[] = {1,2,3,4,5};
        int y[] = new int[5];
        //int y[] = {5,4,3,2,1};
        int z[] = new int[5];

        for (int index = 0; index < x.length; index++) {
            x[index] = index + 1;
        }
        for (int index = 0; index < y.length; index++) {
            y[index] = y.length - index;
        }
        for (int index = 0; index < z.length; index++) {
            // System.out.println(x[index]);
            // System.out.println(y[index]);
            z[index] = x[index] + y[index];
            System.out.println(x[index] + "+" + y[index] + "+" + z[index]);
        }
    };
}