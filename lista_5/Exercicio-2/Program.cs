class program
{
    static void Main(string[] args)
    {
        preencher ();
    }

    //procedimento de preenchimento de vetor:
    static void preencher()
    {
        int[] notas = new int[10];
        //contagem de indices do vetor declarado acima:
        for (int i = 0; i < notas.Length; i++)
        {
            //mensagem para o usuario:
            Console.WriteLine("Linha {0} digite a nota", i);
            // preenchimento do vetor:
            //preenchimento do vetor de acordo com seu indice contado pelo for acima:
            notas[i] = int.Parse(Console.ReadLine());

        }
        //chamada do procedimento e passagem de parametro:
        recebendo(notas);
    }
    //procedimento de soma dos vetores e media do vetor ja recebido por parâmetro:
    static void recebendo(int[] vetor)
    {
        int soma = 0;
        for(int i = 0;i < vetor.Length; i++)
        {
            soma += vetor[i];
        }
        Console.WriteLine("soma das notas digitadas {0}", soma);
        Console.WriteLine("Valor da media das notas acima digitadas = {0}",soma/vetor.Length);
    }



}