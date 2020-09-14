using MotOficina.Views.cliente;
using MotOficina.Views.peca;
using MotOficina.Views.servico;
using MotOficina.Views.veiculo;
using System;
using System.Collections.Generic;
using System.Text;

namespace MotOficina.Views
{
    class MenuCadList
    {
        public static void ExecMenuCadastrosListas()
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("\t========================================\t");
                Console.WriteLine("\t|              MOTOFICINA              |\t");
                Console.WriteLine("\t========================================\t");
                Console.WriteLine("\t|              Cadastros               |\t");
                Console.WriteLine();
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Cadastrar Veículo");
                Console.WriteLine("3 - Cadastrar Peça");
                Console.WriteLine("4 - Cadastrar Serviço");
                Console.WriteLine("5 - Listar Cliente");
                Console.WriteLine("6 - Listar Veículo");
                Console.WriteLine("7 - Listar Peça");
                Console.WriteLine("8 - Listar Serviço");
                Console.WriteLine("0 - SAIR");

                Console.WriteLine("\nEscolha uma Opção:");
                opcao = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                switch (opcao)
                {
                    case 1:
                        CadastraCliente.ExecCadastro();
                        break;
                    case 2:
                        CadastraVeiculo.ExecCadastro();
                        break;
                    case 3:
                        CadastraPeca.ExecCadastro();
                        break;
                    case 4:
                        CadastraServico.ExecCadastro();
                        break;

                    case 5:
                        ListaCliente.ExecListar();
                        break;
                    case 6:
                        ListaVeiculo.ExecListar();
                        break;
                    case 7:
                        //ListaPeca.ExecListar();
                        break;
                    case 8:
                        //ListaServico.ExecListar();
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
