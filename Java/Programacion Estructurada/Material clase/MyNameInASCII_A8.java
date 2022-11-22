class MyNameInASCII_A8 {
    public static void main(String args[]) {
        //iniciar  variable "name" y guardar Edgar Gonz�lez
        String name = "Edgar Gonz�lez";
        //iniciar variable "asciiCode"
        int asciiCode;

        //set "index" to zero; if "index" is less than the length of "name" run for if not stop; add +1 to "index"
        //this runs what's stored in "name" while showing the corresponding ASCII number for that character
        for (int index = 0; index < name.length(); index++) {
            //print character that is stored in "name" corresponding with the possision of "index"
            System.out.print(name.charAt(index) + " ");

            //store same character stored in "name" corresponding with possistion in "index"
            asciiCode = name.charAt(index);

            //print "asciiCode"
            System.out.println(asciiCode + "  ");
        }
    }
}