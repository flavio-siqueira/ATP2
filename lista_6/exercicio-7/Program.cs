using System.ComponentModel.Design;
using System.Runtime.Intrinsics.Arm;

class program
{
    public static void Main(String[] args)
    {
        string resultado;
        Console.WriteLine("Digite uma frase abaixo:");
        string frase = Console.ReadLine();

        //chamada da função
        
        Console.WriteLine("Frase abaixo sem vogais " + vogais(frase));
    }
    // função 
    static int vogais(string frase)
    {
        //variavel string criadas
        string resultado = "";
        string vogais = "aeiouAEIOU";
        int x = 0;
        for (int i = 0; i < frase.Length; i++)
        {
            if (vogais.Contains(frase[i]))
            {
                x++;
                resultado += frase[i]; // concatenação das vogais caso precise mostrar na tela para o usuario.

            }
        }

        return x ;

    }

    //metodo para salvar os valores recebidos.
    static void Salvar(int x)
    {
        StreamWriter sw = new StreamWriter("C:\\Users\adm\\exemplo.txt");

        sw.Write(x);
        sw.Close();


    }


}