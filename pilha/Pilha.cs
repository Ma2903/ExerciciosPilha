public class Pilha{

    public No topo;

    public Pilha(){
        this.topo = null;
    }

    public Boolean estaVazia(){

        if(this.topo == null){
            return(true);
        }
        return(false);
    }

    public void Push(Documento documento){
        
        //CRIAR NOVO NO
        No novoNo = new(documento);

        if(this.estaVazia() == true){ //PILHA VAZIA!
            this.topo = novoNo;
        }
        else{
            novoNo.prox = this.topo;
            this.topo = novoNo;
        }
    }

    public No Pop(){
        No aux = null;
        if(this.estaVazia() == true){
            return(aux);
        }
        else{ //Remoção do topo da pilha
            aux = this.topo;
            this.topo = this.topo.prox;
            return(aux);
        }
    }

    public Boolean Consulta(string nomeDoArquivo , ref No noAtual){

        noAtual = this.topo;
    

        while(noAtual != null){

            if(noAtual.documento.nomeDoArquivo.Equals(nomeDoArquivo)){
                return(true);
            }
            noAtual = noAtual.prox;
        }
        return(false);
    }

    public void Imprimir(){

        No noAux = this.topo;
        
        Console.WriteLine("Documentos: ");
        
        while(noAux != null){
            Console.WriteLine("Nome: " + noAux.documento.nomeDoArquivo + " -> ");
            Console.WriteLine("Extensão: " + noAux.documento.extensaoDoArquivo + " -> ");
            Console.WriteLine("Tamanho: " + noAux.documento.tamanhoDoArquivo + "KB" + " -> ");
            noAux = noAux.prox;
        }
    }

    public void verificaQuantidadeElementos(){

    }

    public void verificaQuantosImpares(){
        
    }
}