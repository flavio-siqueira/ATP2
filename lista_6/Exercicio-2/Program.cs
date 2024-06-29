using System.ComponentModel.Design;

class program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Digite uma frase abaixo:");
        string resultado;
        string frase = Console.ReadLine();
        //chamada da função
        resultado = Semvogais(frase);
        Console.WriteLine("Frase abaixo sem vogais "+resultado);
    }

    static string Semvogais(string frase)
    {
        string resultado = "";
        string vogais = "aeiouAEIOU";

        for (int i=0; i<frase.Length;i++)
        {
          if (!vogais.Contains(frase[i]))
            {
                resultado += frase[i];

            }
        }

        return resultado;

    }




}