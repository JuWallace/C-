using MotOficina.Views.cliente;
using System;
using System.Collections.Generic;
using System.Text;

namespace MotOficina.Views
{
    class MenuPrincipal
    {
        public static void ExecMenuPrincipal()
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("\t========================================\t");
                Console.WriteLine("\t|              MOTOFICINA              |\t");
                Console.WriteLine("\t========================================\t");
                Console.WriteLine("\t|              Principal               |\t");
                Console.WriteLine();
                Console.WriteLine("1 - Cadastraros e Listas");
                Console.WriteLine("2 - Orçamento");
                Console.WriteLine("3 - Entrada Serviço");
                Console.WriteLine("4 - #");
                Console.WriteLine("5 - #");
                Console.WriteLine("0 - SAIR");

                Console.WriteLine("\nEscolha uma Opção:");
                opcao = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                switch (opcao)
                {
                    case 1:
                        MenuCadList.ExecMenuCadastrosListas();
                        break;
                    case 2:
                        //ListaCliente.ExecListas();
                        break;


                    case 0:
                        break;
                    default:
                        break;
                }
                Console.WriteLine("\nVolte sempre, aperte uma tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        }
    }
}
