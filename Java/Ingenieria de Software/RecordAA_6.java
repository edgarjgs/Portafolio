class RecordAA_6 {
    private String numVuelo, origen, destino;
    private int numPasajeros;
    private double precio;
    // caracteristicas
    public RecordAA_6(String nV, String o, String d, int nP, double p) {
        numVuelo = nV;
        origen = o;
        destino = d;
        numPasajeros = nP;
        precio = p;
    }

    // constructores
    public void setnumVuelo(String numV) {
        numVuelo = numV;
    }

    String getNumVuelo() {
        return numVuelo;
    }

    public void setOrigen(String o) {
        origen = o;
    }

    String getOrigen() {
        return origen;
    }

    public void setDestino(String d) {
        destino = d;
    }

    String getDestino() {
        return destino;
    }

    public void setNumPasajeros(int nP) {
        numPasajeros = nP;
    }

    int getNumPasajeros() {
        return numPasajeros;
    }

    public void setprecio(double p) {
        precio = p;
    }

    double getprecio() {
        return precio;
    }

    // comportamiento
    public String toString() {
        return "numero Vuelo " + numVuelo + "origen " + origen + "destino " + destino + "Numero de pasajeros " + numPasajeros + "Precio " + precio;
    }
}