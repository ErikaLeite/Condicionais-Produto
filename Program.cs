using System;

namespace Condicionais_Produto
{
    class Program
    {
        static void Main(string[] args)
        {   
            string nome = "Sabão";
            Console.WriteLine("Escolha a quantidade de "+nome+" e ganhe descontos!\n");
            Console.WriteLine("Nas compras de até 5 unidades ganhe 2% de desconto\nNas compras de até 10 unidades ganhe 3% de desconto\nNas compras acima de 10 unidades ganhe 5% de desconto\n");
            Console.WriteLine("Digite a quantidade escolhida: ");
            double quant = double.Parse(Console.ReadLine());

            //VARIAVEIS P/ CALCULO DE DESCONTO
            double unit = 10;
            double desc2P= 0.02d;
            double desc3P= 0.03d;
            double desc5P= 0.05d; //valores dessa desc imprimindo apenas 3% ao invés de 5. *Corrigir*

            Console.WriteLine("O valor final de sua compra é de: R$ "+CalculoDescontos(quant, unit, desc2P, desc3P, desc5P));



            //FUNÇÃO DESCONTO
            double CalculoDescontos(double quant, double unit, double desc1, double desc2, double desc3)
            {
                if(quant <=5)
                {
                    double valorFinal = quant * unit;
                    double desconto = (quant*unit)*desc1;

                    return valorFinal - desconto;
                }
                else if (quant >5 |quant <=10)
                {
                    double valorFinal = quant * unit;
                    double desconto = (quant*unit)*desc2;
                    return valorFinal - desconto;
                }
                else if(quant >11)
                {   double valorFinal = quant * unit;
                    double desconto = (quant*unit)*desc3;
                    return valorFinal - desconto;
                }else{
                    return 0;
                }

            }
        }
    }
}
