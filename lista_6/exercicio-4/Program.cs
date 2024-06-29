class program //Inicialização da classe 
{
    static void Main(string[] args) //metodo main da classe Main
    {
        Console.Write(arquivo()); //apresentação no console do resultado da função.
    }

    static int arquivo() // declaração da minha função:
    {
    int contador = 0; // variavel  inteira para contagem de dados.
        // instanciando o objeto da classe StreamReader
    StreamReader sr = new StreamReader("C:\\Users\\adm\\Desktop\\exemplo.txt");

    string line = sr.ReadLine(); //metodo da classe.

        // laço de repetição
        for (int i = 0; i < line.Length; i++)
        { 
        if(line[i] == 'a')
            {
                contador++;
            }
        }
        sr.Close(); //fechamento do arquivo lido pela classe.
        return contador; //retorno da função
    }

    
}