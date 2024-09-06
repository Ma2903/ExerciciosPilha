using System.Reflection.Metadata.Ecma335;

public class Documento{
    public string nomeDoArquivo;

    public string extensaoDoArquivo;

    public string tamanhoDoArquivo;

    public Documento(string nomeDoArquivo, string extensaoDoArquivo, string tamanhoDoArquivo){
        this.nomeDoArquivo = nomeDoArquivo;
        this.extensaoDoArquivo = extensaoDoArquivo;
        this. tamanhoDoArquivo = tamanhoDoArquivo;
    }
}