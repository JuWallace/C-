using System;
using System.Collections.Generic;
using System.Text;

namespace GerReservQuartos
{
    class Cadastro
    {
        public static void ExeCadastro()
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("\t========================================\t");
                Console.WriteLine("\t| SISTEMA DE GERENCIAMENTO DE RESERVAS |\t");
                Console.WriteLine("\t========================================\t");
                Console.WriteLine("\t============= CADASTROS ================\t");
                Console.WriteLine();

                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Cadastrar Funcionário");
                Console.WriteLine("3 - Cadastrar Quarto");

                Console.WriteLine("0 - Menu Principal");
                Console.WriteLine("\nEscolha uma opção:");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        view.CadCliente.ExecCadCliente();
                        break;
                    case 2:
                        view.CadFuncionario.ExecCadFuncionario();
                        break;
                    case 3:
                        view.CadQuarto.ExecCadQuarto();
                        break;
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
                        Console.WriteLine("Menu Principal!");
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Opção inválida");
                        break;
                }
                if(opcao == 0)
                {
                    Console.WriteLine();
                }
                //Console.WriteLine("\nAperte uma tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);

        }
    }
}
