using System;
using System.Collections.Generic;
using System.Text;

namespace ListaExercicios01
{
    class Exercicio02
    {
        //Crie um algoritmo que permita fazer três conversões monetárias.O algoritmo
        //deve receber o valor em real(R$) e apresentar os valores convertidos em:
        //a) Dólar(1 dólar = 3,78 reais)
        //b) Euro(1 euro   = 4,21 reais)
        //c) Peso argentino(1 peso argentino = 0,08 reais)

        public static void Exec02()
        {
            double D = 3.78;
            double E = 4.21;
            double P = 0.08;

            Console.WriteLine("Informe o valor em Reais R$: ");
            double real = Convert.ToDouble(Console.ReadLine());


            D = (real / D);
            E = (real / E);
            P = (real / P);

            Console.WriteLine($"O valor de {real.ToString("C2")} convertido em Dólar é de: $ {D.ToString("F2")}");
            Console.WriteLine($"O valor de {real.ToString("C2")} convertido em Euro é de:  E {E.ToString("F2")}");
            Console.WriteLine($"O valor de {real.ToString("C2")} convertido em Peso é de:  $ {P.ToString("F2")}");

            Console.ReadKey();
        }

        
    }
}
