using System;

namespace FilaFIFO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercício 1
            Pilha pilha = new Pilha();
            Documento documento = new Documento("aaaaa", "bbbbbbbbb", "700", 123);
            Documento documento2 = new Documento("ccccc", "dddddddd", "1400", 456);
            Documento documento3 = new Documento("ddddd", "eeeeee", "500", 789);

            // Inserção
            pilha.Push(documento);
            pilha.Push(documento2);
            pilha.Push(documento3);

            // Imprimir a pilha
            pilha.Imprimir();

            // Consultar
            No noAtual = null;
            bool result = pilha.Consulta("aaaaa", ref noAtual);

            if (result)
            {
                Console.WriteLine("Achou!!");
            }
            else
            {
                Console.WriteLine("Não Achou!!");
            }

            // Verificar quantidade de elementos
            pilha.VerificaQuantidadeElementos();

            // Verificar quantos números ímpares existem
            pilha.VerificaQuantosImpares();

            // Remoção
            pilha.Pop();

            // Imprimir a pilha após remoção
            pilha.Imprimir();

            // Verificar quantidade de elementos após remoção
            pilha.VerificaQuantidadeElementos();

            // Verificar quantos números ímpares existem após remoção
            pilha.VerificaQuantosImpares();

            // Exercício 4
            Pilha pilhaOriginal = new Pilha();
            pilhaOriginal.Push(new Documento("a", "b", "1", 1));
            pilhaOriginal.Push(new Documento("b", "c", "-2", -2));
            pilhaOriginal.Push(new Documento("c", "d", "7", 7));
            pilhaOriginal.Push(new Documento("d", "e", "-15", -15));
            pilhaOriginal.Push(new Documento("e", "f", "51", 51));
            pilhaOriginal.Push(new Documento("f", "g", "-23", -23));

            Console.WriteLine("PilhaOriginal (Original):");
            pilhaOriginal.Imprimir();

            // Separar os números em pilhas diferentes
            Pilha pilhaPositivos, pilhaNegativos;
            pilhaOriginal.SepararPositivosENegativos(out pilhaPositivos, out pilhaNegativos);

            Console.WriteLine("PilhaPositivos:");
            pilhaPositivos.Imprimir();

            Console.WriteLine("PilhaNegativos:");
            pilhaNegativos.Imprimir();

            // Exercício 5
            Pilha pilhaLetras = new Pilha();

            // Pilha Inicial: E U A M O P R O G R A M A R
            string letras = "E U A M O P R O G R A M A R";
            foreach (char letra in letras.Replace(" ", ""))
            {
                pilhaLetras.Push(letra);
            }

            Console.WriteLine("Pilha Inicial:");
            pilhaLetras.Imprimir();

            // Inverter a pilha
            pilhaLetras.Inverter();

            Console.WriteLine("Pilha Final (Após inverter):");
            pilhaLetras.Imprimir();

            // Exercício 6
            Pilha pilhaPalavra = new Pilha();

            // Pilha para "RADAR"
            string palavra1 = "RADAR";
            foreach (char letra in palavra1)
            {
                pilhaPalavra.Push(letra);
            }

            Console.WriteLine("Pilha Inicial (RADAR):");
            pilhaPalavra.Imprimir();

            bool resultado1 = pilhaPalavra.VerificarPalindromo();
            Console.WriteLine("Resultado para 'RADAR': " + (resultado1 ? "É PALÍNDROMO" : "NÃO É PALÍNDROMO"));

            // Resetar a pilha
            pilhaPalavra = new Pilha();

            // Pilha para "PROGRAMAR"
            string palavra2 = "PROGRAMAR";
            foreach (char letra in palavra2)
            {
                pilhaPalavra.Push(letra);
            }

            Console.WriteLine("Pilha Inicial (PROGRAMAR):");
            pilhaPalavra.Imprimir();

            bool resultado2 = pilhaPalavra.VerificarPalindromo();
            Console.WriteLine("Resultado para 'PROGRAMAR': " + (resultado2 ? "É PALÍNDROMO" : "NÃO É PALÍNDROMO"));

            // Exercício 7
            Pilha pilhaOriginal2 = new Pilha();
            pilhaOriginal2.Push(10);
            pilhaOriginal2.Push(7);
            pilhaOriginal2.Push(5);
            pilhaOriginal2.Push(12);

            Console.WriteLine("PilhaOriginal2 (Original):");
            pilhaOriginal2.Imprimir();

            Pilha pilhaDestino = new Pilha();
            pilhaOriginal2.TransferirPara(pilhaDestino);

            Console.WriteLine("PilhaDestino (Após Transferir):");
            pilhaDestino.Imprimir();
        }
    }
}