public class AddElementsList_D2 {
    public static void main(String args[]) {
        //int x[] = new int[5];
        double list[] = {40,10,38,24,35};
        double suma = 0;
        for (int index = 0; index < list.length; index++) {
            System.out.println(list[index]);
        }

        for (int index = 0; index < list.length; index++) {
            suma = suma + list[index];
        }
        System.out.println("Suma de los Elementos = " + suma);
    }
}