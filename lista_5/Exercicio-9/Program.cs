class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite os valores da matriz:");
        Matriz();



    }
    //Procedimento de criação de matriz:
    static void Matriz()
    {
        int[,] matriz1 = new int[4,6];
        int[,] matriz = new int[4, 6];
        for(int i = 0; i < matriz1.GetLength(0); i++) 
        {
        for(int j = 0; j < matriz1.GetLength(1); j++)
            {
                matriz[i,j] =int.Parse(Console.ReadLine());
                matriz1[i,j] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
        
        }
        SMatriz(matriz, matriz1);
        DMatriz(matriz, matriz1);
        Escrita(matriz, matriz1);


    }
    //função que retorna os valores das duas matriz somada:
    static int[,] SMatriz(int[,] x, int[,]y)
    {
        int[,] soma =new int[4,6];
        for (int i = 0;i < x.GetLength(0); i++)
        {
            for(int j=0; j<x.GetLength(1); j++)
            {
                soma[i, j] = x[i, j] + y[i, j];

            }
        }

        return soma;
    }
    // função de diferença de matriz A e matriz B: 
    static int[,] DMatriz(int[,] x, int[,] y)
    {
        int[,] subtrair = new int[4, 6];
        for (int i = 0; i < x.GetLength(0); i++)
        {
            for (int j = 0; j < x.GetLength(1); j++)
            {
                subtrair[i, j] = x[i, j] - y[i, j];

            }
        }

        return subtrair;
    }
    // procedimento de escrita das matriz resultantes acima:
    static void Escrita(int[,]x , int[,] y)
    {
        for(int i =0; i<x.GetLength(0); i++)
        {
            for(int j =0; j<x.GetLength(1); j++)
            {
                Console.Write(" "+x[i, j]);
                Console.WriteLine(" ");
                Console.Write(" "+y[i, j]);

            }
        


        }




    }
}