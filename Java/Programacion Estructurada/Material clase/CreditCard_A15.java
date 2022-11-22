import javax.swing.JOptionPane;
public class CreditCard_A15 {
    public static void main(String args[]) {
        //el programa correra en una pestaña aparte (un pane) 
        //iniciar variable "salary", "creditRating" y "dato"
        double salary = 0.0;
        int creditRating = 0;
        String dato;

        //iniciar un pane de input y guardar el resultado en "dato"
        dato = JOptionPane.showInputDialog("Anual Salary?");

        //coger valor guardado en dato y convertirlo en Double y guardar el resultado en "salary"
        salary = Double.parseDouble(dato);

        //iniciar un pane de input y guardar el resultado en "dato"
        dato = JOptionPane.showInputDialog("Credit Rating range 1-10");

        //coger valor guardado en dato y convertirlo en Integer y guardar el resultado en "creditRating"
        creditRating = Integer.parseInt(dato);

        //guardar valor de salary y creditRating en dato
        dato = "salary " + salary + "  credit " + creditRating;

        //si "salary" es mayor o igual que 12000 y el "creditRating" es mayor o igual que 7 corre
        if (salary >= 12000 && creditRating >= 7) {
            //imprimir en la consola Congratulations you qualify!
            System.out.print("Congratulations you qualify!");

            //Display un pane de mensage diciendo "Congratulations you qualify!" con valor guardado en "dato"
            JOptionPane.showMessageDialog(null, dato, "Congratulations you qualify!", JOptionPane.INFORMATION_MESSAGE);
        } else {
            //imprimir en la consola Sorry you don't qualify
            System.out.print("Sorry you don't qualify");

            //Display un pane de mensage diciendo "Sorry you don't qualify" con valor guardado en "dato"
            JOptionPane.showMessageDialog(null, dato, "Sorry you don't qualify", JOptionPane.WARNING_MESSAGE);

        }
    }
}