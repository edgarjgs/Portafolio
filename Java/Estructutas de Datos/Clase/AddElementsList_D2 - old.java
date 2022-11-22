public class UseFunctionToAdd_D3 {
    public static void main(String args[]) {
        //double x[] = new int[5];
        double list[] = {40,10,38,24,35};
        double suma = 0;

        for (int index = 0; index < list.length; index++) {
            //System.out.println(suma);
            System.out.print(list[index] + " + " + suma + " = ");
            suma = suma + list[index];
            System.out.println(suma);
        }
    };
}