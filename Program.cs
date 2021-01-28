using System;

namespace OperadoresAritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma;
            int numero1 = 10;
            int numero2 = 20;
            soma = numero1+numero2;

            int multiplicacao;
            int numero3 = 30;
            int numero4 = 40;
            multiplicacao = numero3*numero4;

            int divisao;
            int numero5 = 60;
            int numero6 = 50;
            divisao = numero5/numero6; 

            double subtracao;
            double numero7 = 9.5;
            double numero8 = 7.6;
            subtracao = numero7-numero8;

            float subtracao2;
            float numero11 =(float) 105.8;
            float numero12 =(float) 97.5;
            subtracao = numero11-numero12;

            decimal multiplicacao2;
            decimal numero9 =(decimal) 55.1;
            decimal numero10 =(decimal) 60.5;
            multiplicacao2 = numero9*numero10;

            bool fran = true;
            bool fra = false;

            Console.WriteLine(soma);
            Console.WriteLine(multiplicacao);
            Console.WriteLine(divisao);
            Console.WriteLine(subtracao);
            Console.WriteLine(multiplicacao2);
            Console.WriteLine(subtracao);
       }
    }
}
