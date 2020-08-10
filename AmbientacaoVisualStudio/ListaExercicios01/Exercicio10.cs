using System;
using System.Collections.Generic;
using System.Text;

namespace ListaExercicios01
{
    class Exercicio10
    {
        //Escrever um algoritmo que leia valores para uma matriz 4 x 4 e imprimir na tela
        //as seguintes informações:
        //a) A soma dos valores das linhas pares;
        //b) A soma dos valores das colunas impares;
        //c) A média dos valores da diagonal principal.

        public static void Exec10()
        {
            int[,] array = new int[4, 4] { 
                { 5, 4, 7, 5 },
                { 2, 6, 8, 7 },
                { 8, 7, 9, 8 },
                { 7, 3, 4, 8 }
            };
            int somaLP = 0, somaCI = 0, mediaDP=0;
            //int[,] array = new int[4, 4];
            //array[0, 0] = 5;
            //array[0, 1] = 4;
            //array[0, 2] = 7;
            //array[0, 3] = 5;
            //array[1, 0] = 2;
            //array[1, 1] = 6;
            //array[1, 2] = 8;
            //array[1, 3] = 7;
            //array[2, 0] = 8;
            //array[2, 1] = 7;
            //array[2, 2] = 9;
            //array[2, 3] = 8;
            //array[3, 0] = 7;
            //array[3, 1] = 3;
            //array[3, 2] = 4;
            //array[3, 3] = 8;

            string matriz = "";
            for (int lin = 0; lin < 4; lin++)
            {
                for (int col = 0; col < 4; col++)
                {
                    matriz += array[lin , col] + " ";
                }
                matriz+= "\n";
            }
            //APRESENTAÇÃO DA MATRIZ
            Console.WriteLine("Sua Matriz é:");
            Console.WriteLine($"{matriz}");

            //SOMA DAS LINHAS PARES
            for (int lin = 0; lin < 4; lin++)
            {
                for (int col = 0; col < 4; col++)
                {
                    if(lin % 2 != 0)
                    {
                        somaLP += array[lin , col];
                    }
                }
            }
            Console.WriteLine($"A SOMA dos elementos das LINHAS pares é: {somaLP}");

            //SOMA DAS COLUNAS IMPARES
            for (int lin = 0; lin < 4; lin++)
            {
                for (int col = 0; col < 4; col++)
                {
                    if ((col+1) % 2 != 0)
                    {
                        somaCI += array[lin, col];
                    }
                }
            }
            Console.WriteLine($"A SOMA dos elementos das COLUNAS ímpares é: {somaCI}");

            //MÉDIA DA DIAGONAL PRINCIPAL
            for (int lin = 0; lin < 4; lin++)
            {
                for (int col = 0; col < 4; col++)
                {
                    if (lin  == col)
                    {
                        mediaDP += (array[lin, col])/4;
                    }
                }
            }
            //Console.WriteLine($"Diagonal PRINCIPAL é: ");
            Console.WriteLine($"A MÉDIA dos elementos da DIAGONAL PRINCIPAL é: {mediaDP}");



        }

    }
}
