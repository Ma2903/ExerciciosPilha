public class No
{
    public No prox;
    public object valor; // Pode ser Documento ou char

    // Construtor para Documento
    public No(Documento documento)
    {
        this.valor = documento;
        this.prox = null;
    }

    // Construtor para char
    public No(char letra)
    {
        this.valor = letra;
        this.prox = null;
    }

    public void Imprimir()
    {
        if (valor is Documento)
        {
            Documento documento = (Documento)valor;
            Console.Write("Documento: " + documento.nomeDoArquivo + " ");
        }
        else if (valor is char)
        {
            char letra = (char)valor;
            Console.Write(letra + " ");
        }
    }
}