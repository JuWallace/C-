using System;

namespace GerReservQuartos
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("\t========================================\t");
                Console.WriteLine("\t| Sistema de Gerenciamento de Reservas |\t");
                Console.WriteLine("\t========================================\t");
                Console.WriteLine();
                
                Console.WriteLine("1 - Cadastros");
                Console.WriteLine("2 - ##");
                Console.WriteLine("3 - ##");

                Console.WriteLine("0 - Sair");
                Console.WriteLine("\nEscolha uma opção:");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                    //Exercicio01 ex = new Exercicio01();
                    //ex.Executar();
                        Cadastro.ExeCadastro();
                        break;
                    //case 2:
                    //    Exercicio02.Exec02();
                    //    break;
                    //case 3:
                    //    Exercicio03.Exec03();
                    //    break;
                    //case 4:
                    //    Exercicio04.Exec04();
                    //    break;
                    //case 5:
                    //    Exercicio05.Exec05();
                    //    break;
                    //case 6:
                    //    Exercicio06.Exec06();
                    //    break;
                    //case 7:
                    //    Exercicio07.Exec07();
                    //    break;
                    //case 8:
                    //    Exercicio08.Exec08();
                    //    break;
                    //case 9:
                    //    Exercicio09.Exec09();
                    //    break;
                    //case 10:
                    //    Exercicio10.Exec10();
                    //    break;

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
                Console.WriteLine("\nVolte sempre, aperte uma tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        }
    }
}
