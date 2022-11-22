public class Exa_5r {
    public static void main(String args[]) {
        int i = 1, t = 0;
        do {
            t = t + 1024;
            System.out.println(i + " kilobyte " + t);
            i = i + 1;
        }
        while (t < 2048);
    }
}