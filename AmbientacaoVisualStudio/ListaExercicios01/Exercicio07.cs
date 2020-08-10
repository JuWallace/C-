using System;
using System.Collections.Generic;
using System.Text;

namespace ListaExercicios01
{
    class Exercicio07
    {
        //Criar um algoritmo que leia um valor positivo inteiro e imprima a sequência
        //Fibonacci até o valor lido.Por exemplo: caso o usuário insira o número 15, o
        //programa deve imprimir na tela os números 0, 1, 1, 2, 3, 5, 8, 13.

        public static void Exec07()
        {
            int n1 = 0, n2 = 1, n3 = 0;
            Console.WriteLine("Digite um valor inteiro: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numero; i++)
            {
                if(i < numero - 1)
                {
                    Console.Write($"{n1} , ");
                }
                else
                {
                    Console.Write($"{n1}");
                }
                n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
            }
            Console.ReadKey();
        }
    }
}
