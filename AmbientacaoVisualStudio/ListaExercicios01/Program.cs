using System;

namespace ListaExercicios01
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine(" -- LISTA DE EXERCÍCIOS 01 -- \n");
                Console.WriteLine("1 - Exercício 01");
                Console.WriteLine("2 - Exercício 02");
                Console.WriteLine("3 - Exercício 03");
                Console.WriteLine("4 - Exercício 04");
                Console.WriteLine("5 - Exercício 05");
                Console.WriteLine("6 - Exercício 06");
                Console.WriteLine("7 - Exercício 07");
                Console.WriteLine("8 - Exercício 08");
                Console.WriteLine("9 - Exercício 09");
                Console.WriteLine("10 - Exercício 10");
                Console.WriteLine("11 - Remover");
                Console.WriteLine("12 - Alterar");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("\nEscolha uma opção:");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        //Exercicio01 ex = new Exercicio01();
                        //ex.Executar();
                        Exercicio01.Exec01();
                        break;
                    case 2:
                        Exercicio02.Exec02();
                        break;
                    case 3:
                        Exercicio03.Exec03();
                        break;
                    case 4:
                        Exercicio04.Exec04();
                        break;
                    case 5:
                        Exercicio05.Exec05();
                        break;
                    case 6:
                        Exercicio06.Exec06();
                        break;
                    case 7:
                        Exercicio07.Exec07();
                        break;
                    case 8:
                        Exercicio08.Exec08();
                        break;
                    case 9:
                        Exercicio09.Exec09();
                        break;
                    case 10:
                        Exercicio10.Exec10();
                        break;

                    //case 11:
                    //    Remover.Executar();
                    //    break;
                    //case 12:
                    //    Alterar.Executar();
                    //    break;
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Saindo...");
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Opção inválida");
                        break;
                }
                Console.WriteLine("\nAperte uma tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        }
    }
}
