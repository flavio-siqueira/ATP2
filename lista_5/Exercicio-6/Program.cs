using System.ComponentModel.Design;

class program
{
    static void Main(String[] args)
    {
        //verificação se o usuário está digitando corretamente os valores pedidos:
        int[] temperatura = new int[5];
        for (int i = 0; i < temperatura.Length; i++) // preenchimento dos valores: 
        {
            temperatura[i] = int.Parse(Console.ReadLine());
            if (temperatura[i]<15 || temperatura[i]>40)
            {
                     i--;
                Console.WriteLine("digite outro valor entre 15 e 40 graus");


            }
        }
        valores(temperatura); //chamada do método:
    }



    static void valores(int[] temperatura) {
        int x = 0;
        int y = 0;
        for (int i = 0; i < temperatura.Length; i++)
        {
            //menor temperatura do registro:
            if (temperatura[i] >= y)
            {
                y = temperatura[i];

            if(x ==0 ){ //como x =0 x sempre será menor do que temperatura, assim coloquei outro if para que mude o valor de x caso comece com a ordem crescente o usuário:
                    x = temperatura[i];


                }

            }
          else // se temperatura não for maior do que y temperatura cairá em x:
            {
                x = temperatura[i];
            }

        }
        Console.WriteLine("Menor temperatura registrada em 30 dias = {0} C° \nMaior temperatura registrada = {1} C°  " ,x,y);
        
    
    
    
    }


}