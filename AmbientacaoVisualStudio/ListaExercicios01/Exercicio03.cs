using System;
using System.Collections.Generic;
using System.Text;

namespace ListaExercicios01
{
    class Exercicio03
    {
        //Ler dois números inteiros e informar qual valor lido é o menor e qual é o maior.
        public static void Exec03()
        {
            int n = 0, menor = 0, maior = 0;

            Console.WriteLine("Informe o primeiro valor: ");
            n = Convert.ToInt32(Console.ReadLine());
            maior = n;
            Console.WriteLine("Informe o segundo valor: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n > maior)
            {
                Console.WriteLine($"O maior número é: {n}");
                Console.WriteLine($"O menor número é: {maior}");
            }
            if (n < maior)
            {
                Console.WriteLine($"O maior número é: {maior}");
                Console.WriteLine($"O menor número é: {n}");
            }
            else if (n == maior)
            {
                Console.WriteLine("Os valores não podem ser iguais, queremos imprimir o Menor e o Maior.");
            }
            Console.ReadKey();
        }
    }
}
