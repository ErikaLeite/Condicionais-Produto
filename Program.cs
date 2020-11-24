using System;

namespace Condicionais_Produto
{
    class Program
    {
        static void Main(string[] args)
        {   
            string nome = "Sabão";
            Console.WriteLine("Escolha a quantidade de "+nome+" e ganhe descontos!\n");
            Console.WriteLine("Digite a quantodade escolhida: ");
            double quant = double.Parse(Console.ReadLine());

            double unit = 10;
            double final = quant * unit;
            

            Console.WriteLine("O valor de "+nome+" é R$ "+unit+ ",00 \n");

            if(quant<=5){

                double perc2= (2/100)*unit;
                double desc2 = final - perc2;

                Console.WriteLine("O valor total: R$"+final+ ",00\nCom o desconto aplicado, sua compra será de: R$ "+desc2);
            }
            // else if(quant >5){

            //     Console.WriteLine("O valor total: R$"+final+ ",00\nCom o desconto aplicado, sua compra será de: R$ "+desc2);

            // }else(quant >10){
                
            //     Console.WriteLine("O valor total: R$"+final+ ",00\nCom o desconto aplicado, sua compra será de: R$ "+desc2);

            // }

        }
    }
}
