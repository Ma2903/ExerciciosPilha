using System;

namespace FilaFIFO{

    class Program{
        static void Main(string[] args){

            Pilha pilha = new();
            Documento documento = new Documento("aaaaa","bbbbbbbbb","700");
            Documento documento2 = new Documento("ccccc","dddddddd","1400");
            //Inserção
            pilha.Push(documento);
            pilha.Push(documento2);
            
            //Percurso = Impressão
            pilha.Imprimir();

            //Consulta
            No noAtual = null;

            bool result = pilha.Consulta("aaaaa", ref noAtual);

            if (result == true){
                Console.WriteLine("Achou!!");
            }
            else
            {
                Console.WriteLine("Não Achou!!");
            }

            //Remoção
            pilha.Pop();
            pilha.Imprimir();
        }
    }
}