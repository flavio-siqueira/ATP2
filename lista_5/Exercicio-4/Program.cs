class program
{
    static void Main(string[] args)
    {//chamada do procedimento no método Main da class program:
        vetores();
            }
    //procedimento de criação dos vetores e preenchimento:
    static void vetores()
    {
        int[] veto1 = new int[10];
        int[] vetor2 = new int[10];
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Digite os dez números do vetor-A\nposição "+i);
            veto1[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < 10; i++)
        {

            Console.WriteLine("Digite os dez numeros do vetor-B");
            vetor2[i] = int.Parse(Console.ReadLine());
        }
        Console.Clear();
        intercalar(veto1, vetor2);
    }

    //procedimento de alternância dos vetores de acordo se i =impar ou i=par:
    static void intercalar(int[] x, int[] y)
    {
        Console.WriteLine("Apresentação dos vetores em ordem alternada");
        for (int i = 0;  i<10; i++) // contagem dos índices:
        {
            if(i%2 ==0) //condição:
            {
                Console.Write(" "+x[i]); //apresentação do valor do vetor:
            
            }
            else // Resultado false da condição acima:
            {
                 Console.Write(" "+y[i]); // apresentação do vetor:
            }
        }






    }
}


