using System;
using System.Collections.Generic;
using System.Text;

namespace ListaExercicios01
{
    class Exercicio05
    {
        //Desenvolver um algoritmo para ler o valor inteiro da idade de uma pessoa e imprimir uma das mensagens:
        //se idade <= 13: Criança, se idade > 13 e <= 18: Adolescente, se idade > 18 e <= 60: Adulto
        //e se idade > 60: Idoso.

        public static void Exec05()
        {
            Console.WriteLine("Digite a idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            if(idade <= 13)
            {
                Console.WriteLine($"Criança {idade}");
            }
            else if(idade > 13  & idade <= 18)
            {
                Console.WriteLine($"Adolescente {idade}");
            }
            else if (idade > 18 & idade <= 60)
            {
                Console.WriteLine($"Adulto {idade}");
            }
            else
            {
                Console.WriteLine($"Idoso {idade}");
            }
        }
        


    }
}
