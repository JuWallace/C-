using System;
using System.Collections.Generic;
using System.Text;

namespace ListaExercicios01
{
    class Exercicio04
    {
        //Os funcionários de uma empresa receberam um aumento de salário:
        //técnicos(código = 1), 50 %; gerentes(código = 2), 30 %; demais funcionários(código = 3),20 %.
        //Escrever um algoritmo para ler o código do cargo de um funcionário e o
        //valor do seu salário atual, calcular e imprimir o novo salário após o aumento.

        public static void Exec04()
        {
            Console.WriteLine("Digite o código do funcionário: ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o salário do funcionário: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Novo salário: {CalcularAumento(codigo,salario):C2}");
        }

        private static double CalcularAumento(int codigo, double salario)
        {
            switch (codigo)
            {
                
                case 1:
                    return salario * 1.5;
                case 2:
                    return salario * 1.3;
                default:
                    return salario * 1.2;
            }
        }


    }
}
