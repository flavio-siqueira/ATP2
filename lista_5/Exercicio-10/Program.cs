class program{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite os números da matriz");
        matriz();






    }
    //procedimento escrita de matriz 10x10:
    static void matriz()
    {
        int[,] matriz = new int[5, 5];
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[i, j] = Convert.ToInt32(Console.ReadLine());


            }
            Console.WriteLine(" ");

        }
        trocar(matriz);
    }
            //procedimento de troca de matriz linha 2 com a linha 8:
            static void trocar(int[,]x)
            {  int[,] y= new int[5,5];
              
        //for para podemos fazer a troca da matriz:
                        for (int j = 0; j < x.GetLength(1); j++)
                    
        {
                            y[2,j] = x[3, j];

                       for(int k = 0; k < y.GetLength(0); k++)
                        Console.WriteLine(" "+ y[j,k]);
                        
        }

                     
       


    }
}