class Example_Exeption_A7 {
    public static void main(String args[]) {
        //iniciar memoria "x", "y" con valor de 10
        int x = 10;
        int y = 10;
        try {
            //iniciar memoria "num" y guardar valor del resultado de la divicion de "x" y "y"
            int num = x / y;
            //imprimir el valor que "num" tenga guardado
            System.out.print(num);
        }

        //solamente se ejecutara si una de las memorias "x" o "y" es 0
        catch (Exception ex) {
            System.out.print("Exeption you can't divide by 0");
        }
        //An exception is unexpected event that occurs during the execution of the program
    }
}