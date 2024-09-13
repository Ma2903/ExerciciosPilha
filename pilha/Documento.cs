public class Documento
{
    public string nomeDoArquivo;
    public string extensaoDoArquivo;
    public string tamanhoDoArquivo;

    public int valor;

    public Documento(string nomeDoArquivo, string extensaoDoArquivo, string tamanhoDoArquivo, int valor)
    {
        this.nomeDoArquivo = nomeDoArquivo;
        this.extensaoDoArquivo = extensaoDoArquivo;
        this.tamanhoDoArquivo = tamanhoDoArquivo;
        this.valor = valor;
    }
}