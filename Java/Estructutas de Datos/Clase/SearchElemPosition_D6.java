public class SearchElemPosition_D6 {
    public static void main(String args[]) {
        char[] list = { 'c', 'o', 'm', 'p', 'u', 't', 'a', 'c', 'i', 'o', 'n' };
        char element = 'u';
        int position;

        for (int index = 0; index < list.length; index++) {
            position = index;
            if (element == list[index]) {
                System.out.println("element: " + element + "\nposition: " + position);
            }
        }
    }
}
/*
 * crear list determinar elemento a busca busqueda del elemento y su posicion
 * imprimir list
 */