public class No{
    // public int valor;
    public No prox;

    public Documento documento;
    public No(Documento documento){
        this.documento = documento;
        this.prox = null;
    }

    public void imprimir(){
        Console.WriteLine("Valor: " + this.documento);
    }

}