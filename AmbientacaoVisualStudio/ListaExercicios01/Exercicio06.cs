using System;
using System.Collections.Generic;
using System.Text;

namespace ListaExercicios01
{
    class Exercicio06
    {
        //Construir um algoritmo que calcule a média aritmética de vários valores inteiros
        //positivos inseridos pelo usuário.O final da leitura acontecerá quando for lido um
        //valor negativo.

        public static void Exec06()
        {
            int numero, somatoria=0, contador=0;
            do
            {
                Console.WriteLine("Digite um número inteiro: ");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero >= 0)
                {
                    somatoria = somatoria + numero;
                    contador++;
                }

            } while (numero >= 0);
            Console.WriteLine($"Média: {somatoria / contador}");


        }




    }
}
