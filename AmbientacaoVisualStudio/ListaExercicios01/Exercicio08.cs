using System;
using System.Collections.Generic;
using System.Text;

namespace ListaExercicios01
{
    class Exercicio08
    {
        //Escrever um algoritmo que receba 20 valores, após a leitura dos dados permitir
        //que o usuário procure um determinado valor, caso esse valor seja
        //encontrado, imprimir a posição do valor encontrado, caso contrário, informar que
        //não existe nenhum valor dentro do vetor.

        public static void Exec08()
        {
            int[] vetor = new int[5];

            // INSERÇAO DOS NUMEROS NO VETOR
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine($"Digite um valor para o {i}º: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }

            // IMPRESSAO DOS NUMEROS DO VETOR
            Console.WriteLine();
            Console.WriteLine("Os valores armazenados no vetor são:");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"{vetor[i]}");

            }
            Console.WriteLine();
            Console.WriteLine("Qual valor deseja descobrir seu Index? ");
            int valor = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < vetor.Length; i++)
            {
                if (valor == vetor[i])
                {
                    Console.WriteLine($"O Valor pesquisado está no Index: {i}");
                }
            }
            Console.WriteLine("Valor não encontrado dentro do VETOR");
            Console.ReadKey();
            


        }
    }
}
