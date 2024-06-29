class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite os elementos da matriz");
        int x = int.Parse(Console.ReadLine()); // variável onde o usuário digitará o valor para ser representado na matriz: 
        int[,] matriz = new int[x,x]; // declaração da matriz:
        for(int i = 0; i < matriz.GetLength(0); i++) // Contagem de linhas pelo método "GetLength" e for:
        {
            for(int j = 0; j < matriz.GetLength(1); j++) //contagem de colunas da matriz:
            {
                matriz[i,j] = int.Parse(Console.ReadLine()); //preenchimento da matriz pelo usuário:
            }
            Console.WriteLine(" ");
        }

        diagonalP(matriz);

    }

    //Método onde objetivo é somar a diagonal principal:
    static void diagonalP(int[,] x)
    {
        int soma = 0;
        for (int i = 0;i < x.GetLength(0); i++)
        {      
                soma += x[i,i];

        Console.Write("  " + x[i, i]);

        }
        Console.WriteLine("\nsoma dos elementos da diagonal " + soma);

    }



}