class program
{
    static void Main(string[] args)
    {
        bool y = false;

        //acertei é diferente de não acertei se sim
        do
        {
            Console.WriteLine("Digite um número inteiro entre 10 e 50");
            int x = int.Parse(Console.ReadLine());
            int[] vetor = sorteio();
            y = acertou(vetor, x);
            acertou(vetor, x);
            Console.Clear ();
        } while (y != true);
        Console.WriteLine("Parabéns você acerto o número do sorteio");

    }

    //função de sorteio de 3 números:
    static int[] sorteio()
    {
        int[] vetor = new int[3]; //declaração do vetor:
        //Class Random instanciada utilizando o método de sorteio .Next();
        Random random = new Random();
        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = random.Next(10, 50);
           
        }
        return vetor;
    }
        //procedimento para verificar se o usuário acertou algum número:
        static bool acertou(int[] vetor, int x)
        {

            for (int i = 0; i < 3; i++)
            {
            if (vetor[i] == x) return true;
            }

            return false;
        }


 

}
