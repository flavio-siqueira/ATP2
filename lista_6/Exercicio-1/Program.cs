using System; //biblioteca do sistema:

class Programa //inicialização da classe program:
{
    // Função para contar espaços em branco em uma frase
    static int ContarEspacosBrancos(string frase) //funcao contar espaços em brancos:
    {
        int contador = 0; //contador:
        //condições de comando: 
        for (int i = 0; i < frase.Length; i++)
        {
            if (frase[i] == 'a')
            {
                contador++;
            }
        }
        return contador;
    }


    //Procedimento Main chamada de todas as funções e procedimento.
    static void Main()
    {
        // Solicita ao usuário que digite uma frase
        Console.WriteLine("Digite uma frase: ");
        string frase = Console.ReadLine();

        // Chama a função e exibe o resultado
        int espacosBrancos = ContarEspacosBrancos(frase);
        Console.WriteLine($"A frase contém {espacosBrancos} espaços em branco.");
    }
}