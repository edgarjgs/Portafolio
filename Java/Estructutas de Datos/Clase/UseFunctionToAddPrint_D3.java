public class UseFunctionToAddPrint_D3 {
    public static void main(String args[]) {
        double list[] = {4,1,-3,2,6};
        double total = 0;
        total = addElemtoList(list);
        printList(list);
        System.out.print("Total = "+ total);
    }

    public static double addElemtoList(double[] x) {
        double sum = 0;
        for (int index = 0; index < x.length; index++) {
            sum = sum + x[index];
        }
        return sum;
    }

    public static void printList(double[] k) {
        for (int i = 0; i < k.length; i++) {
            System.out.println(k[i]);
        }
    }
}