using System.Runtime.Intrinsics.Arm;

class program
{

    //metodo Main da minha classe principal.
    static void Main (string[] args)
    {
        //Mensagem para usuario.
        Console.WriteLine("Digite um numero qualquer");
        int x = int.Parse(Console.ReadLine()); //declaração e entrada de valores do usuario.
        int y = divisores(x); // recebimento de valor da função divisores.
        Salvar(y); // chamada da função Salvar para armazenamento dos dados no arquivo .txt
    }


    //função retornando valor inteiro e recebendo um parametro.
    static int divisores(int n)
    {
        int aux = 0;
        //laço de repetição onde faço a contagem de i para podemos fazer a divisão.
        for(int i = 1; i <=n; i++)
        {
            //condições
            if((n%i) == 0)
            {
                Console.WriteLine("{0} é divisor do numero digitado",i);
                aux += i; //variável auxiliar que recebe numero di divisor acima e soma com os demais valores já somados.
            }
        }
        return aux;
    }

    //metodo de salvar arquivo na .txt
    static void Salvar(int t)
    {
         //instanciamento da classe StreamWriter onde mandamos os arquivos daqui para serem salvos no arquivo exemplo.txt 
        StreamWriter sw = new StreamWriter("C:\\Users\\adm\\Desktop\\exemplo.txt");

        sw.Write(t); // abertura e valor de t sendo salvo no exemplo.txt
        sw.Close(); //fechamento do arquivo que foi aberto.


    }


}