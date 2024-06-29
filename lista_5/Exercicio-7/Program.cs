class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("digite o valor da matriz quadrada");
        int valor = int.Parse(Console.ReadLine ());
        int[,] x = new int[valor,valor];
        x =  Matriz(valor);     
        
        Console.WriteLine("Valor da soma da penúltima linha da matriz quadrada " +Somal4(x));
        Console.WriteLine("Valor da soma da segunda linha da matriz quadrada " + Somal2(x));
        Console.WriteLine("Valor da soma da diagonal linha da matriz quadrada " + SomaD(x,valor));
        
        Console.WriteLine("Valor da soma da diagonal secundária linha da matriz quadrada " + SomaS(x, valor));
        Console.WriteLine("Valor da soma da diagonal secundária linha da matriz quadrada " + SomaDS(x, valor));


    }

    //procedimento de preenchimento da Matriz²:
    static int[,] Matriz(int x)
    {
       
        int[,] matriz = new int[x, x];

        for (int i = 0; i < matriz.GetLength (0); i++)
        {

            for (int j = 0; j < matriz.GetLength (1); j++)
            {

                matriz[i, j] = int.Parse(Console.ReadLine());
            }
            Console.Clear();

        }
        return matriz;
    }
        //função de soma da linha 4 da matriz:
        static int Somal4(int[,] x)
        {
        int penultimaLinha = 0;
            int valorSoma = 0;
              for(int j = 0;j <x.GetLength(1); j++)//contagem da coluna da matriz 
                {
                penultimaLinha = x.GetLength(0); //valor da ultima linha da matriz salvo:
                    valorSoma += x[penultimaLinha -1, j]; //penultima Linha linha da matriz menos 1 para obter a penultima linha:

                }
                        
            return valorSoma;

        }

    //função soma da segunda coluna da matriz:

    static int Somal2(int[,] x)
    {
        int penultimaLinha = 0;
        int valorSoma = 0;
        for (int j = 0; j < x.GetLength(1); j++)//contagem da coluna da matriz 
        {
            penultimaLinha = x.GetLength(0); //valor da ultima linha da matriz salvo:
            valorSoma += x[penultimaLinha - (penultimaLinha -2), j]; //penúltima Linha linha da matriz menos 1 para obter a penultima linha:

        }

        return valorSoma;

    }
    //Soma da diagonal principal da Matriz:
    static int SomaD(int[,] y, int x)
    {
        int soma = 0;
        for(int i = 0; i< x; i++)
        {   soma += y[i, i];    }


        return soma;
    }

    //Soma da diagonal secundaria da Matriz:
    static int SomaS(int[,] y, int x)
    {
        int soma = 0;
        for (int i = 0; i < x; i++)
        { soma += y[i,  x-i]; }


        return soma;
    }


    static int SomaDS(int[,] x, int y)
    {
        int soma = 0;
        for (int i = 0; i < x.GetLength(0); i++)
        {

            for (int j = 0; j < x.GetLength(1); j++)
            {

                soma += x[i, j];
            }

        }
        return soma;
    }

}
