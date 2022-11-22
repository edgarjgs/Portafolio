   import java.util.Scanner;
   public class CreditCard_A14 {
       public static void main(String args[]) {
           //iniciar variable "salary" y "creditRating" 
           double salary = 0.0;
           int creditRating = 0;

           //iniciar Scanner
           Scanner edgarG = new Scanner(System.in);

           //imprimir en la consola
           System.out.print("Salary? ");

           //pedir al usuario que escriba y guardar el resultado el "salary" 
           salary = edgarG.nextDouble();

           //inprimir en la consola
           System.out.print("Credit Rating? ");

           //pedir al usuario que escriba y guardar el resultado el "creditRating" 
           creditRating = edgarG.nextInt();

           //si "salary" es mayor o igual que 12000 y el "creditRating" es mayor o igual que 7 corre
           if (salary >= 12000 && creditRating >= 7) {
               //salir de main() y entrar a Qualify()
               Qualify();

           } else {
               //salir de main() y entrar a noQualify()
               noQualify();
           }
           //termina programa aquí
       }

       //programas que correran en main() 
       public static void Qualify() {
           //imprimir resultado en la consola
           System.out.print("Congratulations you qualify");
           //volver a main()
       }
       public static void noQualify() {
           //imprimir resultado en la consola
           System.out.print("sorry you don't qualify");
           //volver a main()
       }
   }