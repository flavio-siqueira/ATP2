class program
{
    static void Main(string[] args)
    {
        Console.WriteLine(lerArquivo()+" Linhas apresentadas acima");
    }

    static int lerArquivo()
    {
        int contador = 0;
        string[] line = new string[3]; // vetor de 10 posições sendo assim poderemos contar até 10 linhas no maximo.

        //lendo os arquivos .txt
        StreamReader sr = new StreamReader("C:\\Users\\adm\\Desktop\\exemplo.txt");
      
        for (int i = 0; i <line.Length; i++)
        {
            contador = i; // variavel contador recebe ultimo valor de i.

            line[i] = sr.ReadLine();
            //apresentação das linhas para o usuário:
            Console.WriteLine(line[i]);

        }

        return contador +1;

    }
}