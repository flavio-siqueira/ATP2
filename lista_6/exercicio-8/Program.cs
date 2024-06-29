using System.Runtime.Intrinsics.Arm;

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Seja bem vindos ");
        entradaDados();



    }
    static void Salvar()
    {
     


    }

   
    static void entradaDados()
    {
        double mensal = 0;

    Console.WriteLine("Digite o total de veiculos da locadora");
        int totalVeiculo = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o valor do aluguel do veiculos");
    
            double y = double.Parse(Console.ReadLine());
        
        veiculoAlugados(totalVeiculo);
        mensal = faturamento_Mensal(totalVeiculo, y);
        faturamento_Anual(mensal);
        Multas(mensal);
        manutencao(totalVeiculo);

        StreamWriter sw = new StreamWriter("C:\\Users\adm\\Desktop\\exemplo.txt");
       sw.WriteLine(mensal,faturamento_Anual(mensal),Multas(mensal),manutencao(totalVeiculo));
    }

    static int veiculoAlugados(int valor)
    {
        return valor / 3;
    }

    static double faturamento_Mensal(int valor, double valorVenda)
    {
        return (valor * valorVenda) / 3;    
    }

    static double faturamento_Anual( double x )
    {
        return x * 12;
    }


   static public double Multas(double valor)
    {
        double multa = 0;
        multa = (valor / 10) * 0.2;

            return multa;
    }

    static public double manutencao(int veiculo )
    {
        double manutencao = 0;
        manutencao = (veiculo* 0.02) * 600;
        return manutencao;
    }
}

