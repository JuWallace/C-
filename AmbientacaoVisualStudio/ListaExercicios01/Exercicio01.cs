using System;
using System.Collections.Generic;
using System.Text;

namespace ListaExercicios01
{
    class Exercicio01
    {
        //Escrever um algoritmo que receba a altura e a largura de um retângulo e calcule
        //a sua área, ao final o algoritmo deve mostrar o resultado na tela.

        public static void Exec01()
        {
            Console.WriteLine("\nCálculo da área do retângulo\n");
            Console.WriteLine("Informe a Altura: ");
            int altura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe a Largura: ");
            int largura = Convert.ToInt32(Console.ReadLine());
            int area = CalcularArea(altura, largura);

            Console.WriteLine($"O valor da área do retângulo é: {area}");

            Console.ReadKey();
        }

        private static int CalcularArea(int altura, int largura)
        {
            //area = (largura * altura);
            return altura * largura;
        }
    }
}
