class CallingFunction_A13 {
    public static void main(String arg[]) {
        //el programa buscara y correra codigo fuera de main

        //print en la consola
        System.out.println("print from main\n");

        //salir del main y entrar a display()
        display();

        //print en la consola
        System.out.println("\nBack to print from main\n");

        //salir del main y entrar a myInformation()
        myInformation();
    }
    //termina programa aquí

    //programas que correran en main() 
    public static void display() {
        //imprimir resultado en la consola
        System.out.println("\nprint from display()");
        //volver a main()
    }
    public static void myInformation() {
        //imprimir resultado en la consola
        System.out.println("Edgar J. Gonzalez Serrano: Code 307\nComp 2315\n17/abril/2018");
        //volver a main()
    }

}