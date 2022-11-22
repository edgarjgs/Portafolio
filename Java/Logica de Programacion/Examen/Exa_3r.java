public class Exa_3r {
    public static void main(String args[]) {
        int number = 9;
        for (int i = 1; i <= 8; i++) {
            System.out.println(i + "  bit ");
            number = number - 1;
        }
        System.out.print(number + "  Byte  of memory ");
    }
}