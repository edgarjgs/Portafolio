//BooleanLogicRelationalOperators_A9.java
// Programador: Edgar Gonzalez Serrano
// CODIGO: 512

public class BooleanLogicRelationalOperators_A9 {
    public static void main(String args[]) {
        int x, y, z;
        x = 33;
        y = 4;
        z = -5;
        boolean r, p, q;
        p = true;
        q = true;

        System.out.print("Operadores Relacionales \n");
        //1 menor
        r = x < y;
        System.out.printf("\n %d < %d is %b", x, y, r);
        //2 menor o igual
        r = x <= z;
        System.out.printf("\n %d <= %d is %b", x, z, r);
        //3 mayor
        r = x > y;
        System.out.printf("\n %d > %d is %b", x, y, r);
        //4 mayor o igual
        r = x >= y;
        System.out.printf("\n %d >= %d is %b", x, z, r);
        //5 igual
        r = x == y;
        System.out.printf("\n %d = %d is %b", x, y, r);
        //6 diferente
        r = x != y;
        System.out.printf("\n %d != %d is %b", x, z, r);

        //AND
        System.out.println("\n \n Boolean Logic AND \n ");
        System.out.println("  p  AND q is r ");

        //true true
        r = p && q;
        System.out.printf("\n %b && %b is %b", p, q, r);

        // true false
        r = p && !q;
        System.out.printf("\n %b && %b is %b", p, !q, r);

        //false true
        r = !p && q;
        System.out.printf("\n %b && %b is %b", !p, q, r);

        //false false
        r = !p && !q;
        System.out.printf("\n %b && %b is %b", !p, !q, r);


        //OR
        System.out.println("\n \n Boolean Logic OR \n ");
        System.out.println("  p  AND q is r ");

        //true true
        r = p || q;
        System.out.printf("\n %b  || %b is %b", p, q, r);

        // true false
        r = p || !q;
        System.out.printf("\n %b  || %b is %b", p, !q, r);

        //false true
        r = !p || q;
        System.out.printf("\n %b || %b is %b", !p, q, r);

        //false false
        r = !p || !q;
        System.out.printf("\n %b || %b is %b", !p, !q, r);

        //NOT
        System.out.println("\n \n Boolean Logic Not \n ");
        System.out.println(" p ");

        //true false

        System.out.printf("\n %b %b", p, !p);

        //false true

        System.out.printf("\n %b %b", !p, p);
    }
}