using System.Runtime.Intrinsics.Arm;

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a quantidade de alunos");
        int x = int.Parse(Console.ReadLine());
        //declarações do vetores
        string[] telefone = new string[x];
        string[] alunos = new string[x];

        for (int i = 0; i < x; i++)
        {
            Console.WriteLine("Digite o nome do aluno");
            alunos[i] = Console.ReadLine();

            Console.WriteLine("Digite o telefone do aluno");
            telefone[i] = Console.ReadLine();


        }
        Salvar(alunos, telefone);
        Console.WriteLine("digite o nome do aluno na busca");
        Buscar(alunos,telefone);
      
    }
   

    //buscar por posições do vetor:
    static void Buscar(string[] alunos, string[] tel)
    {
        for (int i = 0; i < alunos.Length; i++)
        {
            if (alunos[i] == Console.ReadLine()) //condição caso o usuário digite o valor correspondente:
                Console.WriteLine("Nome do aluno " + alunos[i] + "  telefone do aluno" + tel[i]);
                            

        }
    }

    //metodo de salvar arquivos txt.
    static void Salvar(string[] alunos, string[] tel)
    {
        StreamWriter sw = new StreamWriter("C:\\Users\\adm\\Desktop\\exemplo.txt");
        for (int i = 0; i < alunos.Length; i++)
        {

            sw.WriteLine("alunos "+alunos[i]);
            sw.WriteLine("telefone "+tel[i]);

        }
        sw.Close();

    }
}