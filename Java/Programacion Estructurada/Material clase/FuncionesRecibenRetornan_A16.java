import java.util.Scanner;
class FuncionesRecibenRetornan_A16

{
    public static void main(String args[]) {
        Scanner edgarG = new Scanner(System.in);
        int n, m, total1, option;
        double a[] = { 51.55, 54.76, 66.18, 846.51 };
        double total2;
        String name, code, identidad;
        System.out.println("\n       MENU");
        System.out.println("1. Identificar usuario");
        System.out.println("2. Suma los n =< x <= m");
        System.out.println("3. Suma los elementos del arreglo");
        System.out.println("4. exit");
        System.out.print("\nPara continuar suministre 1, 2, 3 o 4  ");

        option = edgarG.nextInt();
        switch (option) {
            case 1: {
                System.out.println("Tu nombre? ");
                name = edgarG.next();
                System.out.println("Tu codigo? ");
                code = edgarG.next();
                identidad = suIdentidad(name, code);
                System.out.println("Tu  identidad es: " + identidad);
                break;
            }
            case 2: {
                System.out.println("suministre numero entero para n? ");
                n = edgarG.nextInt();
                System.out.println("suministre numero entero para m? ");
                m = edgarG.nextInt();
                total1 = sumaNtoM(n, m);
                System.out.println("suma de: " + n + " =< x <= " + m + " es: " + total1);

                break;
            }
            case 3: {
                total2 = sumaRacionales(a);
                System.out.println("la suma de 51.55, 54.76, 66.18, 846.51 es: " + total2);
                break;
            }
            case 4: {
                System.exit(0);
                break;
            }

            default: {
                System.out.println("Numero escrito no esta en las opciones");
                break;
            }

        }

    }

    public static String suIdentidad(String s1, String s2) {
        String s3;
        s3 = s1 + "  " + s2;

        return s3;
    }

    public static int sumaNtoM(int x, int y) {
        int suma1 = 0;

        for (int i = x; i <= y; i++) {
            suma1 = suma1 + i;
        }
        return suma1;
    }

    public static double sumaRacionales(double k[]) {
        double suma2 = 0.0;

        for (int index = 0; index < k.length; index++) {
            suma2 = suma2 + k[index];
        }
        return suma2;
    }
    public static void x() {
        System.out.print("\nHola");
    }
}