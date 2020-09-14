using GerReservQuartos.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerReservQuartos.view
{
    class ListFuncionarios
    {
        public static void ExecListarFuncionarios()
        {
            //model.Funcionario funcionario = new model.Funcionario();
            List<string> lstFuncionarios = new List<string>();

            Console.Clear();
            Console.WriteLine("\t========================================\t");
            Console.WriteLine("\t| SISTEMA DE GERENCIAMENTO DE RESERVAS |\t");
            Console.WriteLine("\t========================================\t");
            Console.WriteLine("\t          LISTA DE FUNCIONÁRIOS         \t");
            Console.WriteLine("\t========================================\t");
            Console.WriteLine();

            //LISTAR FUNCIONÁRIOS
            Console.WriteLine($"{lstFuncionarios}");
        }
    }
}
