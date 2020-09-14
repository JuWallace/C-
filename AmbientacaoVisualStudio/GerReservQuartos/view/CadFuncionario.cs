using System;
using System.Collections.Generic;
using System.Text;

namespace GerReservQuartos.view
{
    class CadFuncionario
    {
        public static void ExecCadFuncionario()
        {
            model.Funcionario funcionario = new model.Funcionario();
            List<string> lst = new List<string>();

            int op = 1;
            Console.Clear();
            Console.WriteLine("\t========================================\t");
            Console.WriteLine("\t| SISTEMA DE GERENCIAMENTO DE RESERVAS |\t");
            Console.WriteLine("\t========================================\t");
            Console.WriteLine("\t         CADASTRO DE FUNCIONÁRIO        \t");
            Console.WriteLine("\t========================================\t");
            Console.WriteLine();

            //Adiciona o item à lista
            while (op == 1)
            {
                Console.WriteLine("Digite o Nome: ");
                funcionario.Nome = Console.ReadLine();
                Console.WriteLine("Digite a Matrícula: ");
                funcionario.Matricula = Console.ReadLine();
                Console.WriteLine("Digite o Contato: ");
                funcionario.Contato = Console.ReadLine();

                Console.WriteLine("Deseja inserir outro cliente? 1-SIM | 2-NÃO");
                op = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
