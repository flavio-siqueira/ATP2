class program
{static void Main(string[] args)
    {//chamada do procedimento no método main:
        preencher();

    }

    static void preencher()
    {
        int[] vetor = new int[10];
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("digite o elemento da posição {0}", i);
            vetor[i] = int.Parse(Console.ReadLine());
        }
        //chamada do procedimento dentro de outro procedimento:
        negativos(vetor);

        //procedimento de  recebimento do vetor preenchido acima apresentando o depois apenas os numeros negativos:

    }
    static void negativos(int[] vetor)
    {
        
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] <= 0)
            {
                int[] negativo = new int[10];
                negativo[i] = vetor[i];
                Console.WriteLine("números negativos {0} ", negativo[i]);

            }
        }
       



    }
}

