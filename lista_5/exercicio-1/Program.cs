using System;

class Program
{
    static void Main()
    {
        int[] N = new int[20];
        int menorElemento, posicao;

        // Lendo os elementos do vetor
        Console.WriteLine("Digite os 20 elementos do vetor:");
        for (int i = 0; i < 20; i++)
        {
            Console.Write("Elemento {0}: ", i + 1);
            N[i] = int.Parse(Console.ReadLine());
        }

        // Inicializando menorElemento e posicao com os valores do primeiro elemento do vetor
        menorElemento = N[0];
        posicao = 0;

        // Encontrando o menor elemento e sua posição
        for (int i = 1; i < 20; i++)
        {
            if (N[i] < menorElemento)
            {
                menorElemento = N[i];
                posicao = i;
            }
        }

        // Exibindo o menor elemento e sua posição
        Console.WriteLine("O menor elemento de N é: {0} e sua posição dentro do vetor é: {1}", menorElemento, posicao);
    }
}