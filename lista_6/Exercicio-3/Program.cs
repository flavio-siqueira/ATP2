using System;


//Está resolução foi buscada na internet sendo feitas alterações e buscas por mais conhecimento onde agregou muito.
class Program
{
    static void Main()
    {
        // Texto de entrada
        string texto = "a ligeira raposa marrom saltou sobre o cachorro cansado";

        // Convertendo o texto para maiúsculas conforme o exemplo fornecido
        string textoMaiusculo = texto.ToUpper();

        // Chamando a função para codificar o texto
        string textoCodificado = CodificarCesar(textoMaiusculo, 3);

        // Exibindo o resultado
        Console.WriteLine("String original: " + texto);
        Console.WriteLine("Nova string: " + textoCodificado);
    }

    static string CodificarCesar(string texto, int deslocamento)
    {
        // Array de caracteres para armazenar a string codificada
        char[] resultado = new char[texto.Length];

        for (int i = 0; i < texto.Length; i++)
        {
            char c = texto[i];

            // Verifica se o caractere é uma letra
            if (char.IsLetter(c))
            {
                // Determina o ponto de início do alfabeto ('A' para maiúsculas, 'a' para minúsculas)
                char offset = char.IsUpper(c) ? 'A' : 'a';

                // Calcula a nova letra considerando o deslocamento e o ponto de início
                resultado[i] = (char)(((c + deslocamento - offset) % 26) + offset);
            }
            else
            {
                // Mantém caracteres não alfabéticos inalterados
                resultado[i] = c;
            }
        }

        // Retorna a nova string codificada
        return new string(resultado);
    }
}