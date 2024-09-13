public class Pilha
{
    public No topo;

    public Pilha()
    {
        this.topo = null;
    }

    public bool EstaVazia()
    {
        return this.topo == null;
    }

    public void Push(object valor)
    {
        No novoNo;

        if (valor is Documento documento)
        {
            novoNo = new No(documento);
        }
        else if (valor is char letra)
        {
            novoNo = new No(letra);
        }
        else
        {
            throw new ArgumentException("Tipo de valor não suportado.");
        }

        if (this.EstaVazia())
        {
            this.topo = novoNo;
        }
        else
        {
            novoNo.prox = this.topo;
            this.topo = novoNo;
        }
    }

    public object Pop()
    {
        if (this.EstaVazia())
        {
            throw new InvalidOperationException("A pilha está vazia.");
        }

        object valor = this.topo.valor;
        this.topo = this.topo.prox;
        return valor;
    }

    public bool Consulta(string nomeDoArquivo, ref No noAtual)
    {
        noAtual = this.topo;

        while (noAtual != null)
        {
            if (noAtual.valor is Documento documento &&
                documento.nomeDoArquivo.Equals(nomeDoArquivo))
            {
                return true;
            }
            noAtual = noAtual.prox;
        }
        return false;
    }

    public void Imprimir()
    {
        No noAux = this.topo;

        Console.WriteLine("Elementos: ");
        while (noAux != null)
        {
            noAux.Imprimir();
            noAux = noAux.prox;
        }
        Console.WriteLine();
    }

    public void SepararPositivosENegativos(out Pilha pilhaPositivos, out Pilha pilhaNegativos)
    {
        pilhaPositivos = new Pilha();
        pilhaNegativos = new Pilha();
        
        No noAtual = this.topo;

        while (noAtual != null)
        {
            if (noAtual.valor is Documento documento && int.TryParse(documento.tamanhoDoArquivo, out int valor))
            {
                if (valor >= 0)
                {
                    pilhaPositivos.Push(new Documento("", "", valor.ToString(), valor));
                }
                else
                {
                    pilhaNegativos.Push(new Documento("", "", valor.ToString(), valor));
                }
            }
            noAtual = noAtual.prox;
        }
    }

    public void VerificaQuantidadeElementos()
    {
        int contador = 0;
        No noAtual = this.topo;

        while (noAtual != null)
        {
            contador++;
            noAtual = noAtual.prox;
        }

        Console.WriteLine("Quantidade de elementos na pilha: " + contador);
    }

    public void VerificaQuantosImpares()
    {
        int contadorImpares = 0;
        No noAtual = this.topo;

        while (noAtual != null)
        {
            if (noAtual.valor is Documento documento && int.TryParse(documento.tamanhoDoArquivo, out int valor) && valor % 2 != 0)
            {
                contadorImpares++;
            }
            noAtual = noAtual.prox;
        }

        Console.WriteLine("Quantidade de números ímpares na pilha: " + contadorImpares);
    }

    public void Inverter()
    {
        Pilha pilhaTemp = new Pilha();
        while (!EstaVazia())
        {
            object valor = Pop();
            pilhaTemp.Push(valor);
        }
        this.topo = pilhaTemp.topo;
    }

    // Função para verificar se a pilha representa um palíndromo
    public bool VerificarPalindromo()
    {
        // Construir a palavra/frase a partir da pilha
        string palavra = "";
        No noAtual = this.topo;

        while (noAtual != null)
        {
            if (noAtual.valor is char letra)
            {
                palavra += letra;
            }
            noAtual = noAtual.prox;
        }

        // Verificar se é um palíndromo
        string palavraInvertida = new string(palavra.Reverse().ToArray());
        return palavra.Equals(palavraInvertida, StringComparison.OrdinalIgnoreCase);
    }
    // Função para transferir elementos de uma pilha para outra preservando a ordem
    public void TransferirPara(Pilha pilhaDestino)
    {
        Pilha pilhaAuxiliar = new Pilha();

        // Transferir elementos da pilha atual para a pilha auxiliar
        while (!EstaVazia())
        {
            pilhaAuxiliar.Push(Pop());
        }

        // Transferir elementos da pilha auxiliar para a pilha destino
        while (!pilhaAuxiliar.EstaVazia())
        {
            pilhaDestino.Push(pilhaAuxiliar.Pop());
        }
    }
}