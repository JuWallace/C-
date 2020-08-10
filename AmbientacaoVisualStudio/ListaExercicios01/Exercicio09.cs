using System;
using System.Collections.Generic;
using System.Text;

namespace ListaExercicios01
{
    class Exercicio09
    {
        //Desenvolver um algoritmo para receber 10 valores dentro de um vetor, ordenar
        //do menor para o maior os valores lidos em vetor auxiliar e ao final, imprimir o
        //vetor ordenado na tela.

        public static void Exec09()
        {
            int[] vetor = new int[10];

            // INSERÇAO DOS NUMEROS NO VETOR
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine($"Digite um valor para o {i}º: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < vetor.Length; i++)
            {
                for (int j = 0; j < vetor.Length; j++)
                {
                    if (vetor[i] < vetor[j])
                    {
                        int aux = vetor[i];
                        vetor[i] = vetor[j];
                        vetor[j] = aux;
                    }
                }
            }
            Console.WriteLine("Os valores em ordem crscente do vetor são:");
            for (int k = 0; k < vetor.Length; k++)
            {
                Console.Write($"{vetor[k]} ");
            }

            Console.ReadKey();
        }
    }
}
