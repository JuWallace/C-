using System;

namespace AmbientacaoVisualStudio
{
    class Program
    {
        static void Main(string[] args)
        {
            String nome;
            int idade;

            //Imprimir Mensagem
            Console.WriteLine("Teste de Mensagem!!");

            //\n Pular uma linha
            //\t Criar a tabulação
            Console.WriteLine("\nDigite o seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("\nDigite a Idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nO nome digitado foi: " + nome);
            //Console.WriteLine($"\nO nome digitado foi: {nome}");

            Console.WriteLine("A idade é: " + idade + " anos.");

            if (idade >= 18)
            {
                Console.WriteLine("Maior de idade!");
            }
            else
            {
                Console.WriteLine("Menor de idade!");
            }

            

            Console.ReadKey();

           

        }
    }
}
