using MotOficina.Dal;
using MotOficina.Models;
using System;


namespace MotOficina.Views.cliente
{
    class ListaCliente
    {
        public static void ExecListar()
        {
            Console.WriteLine("\t========================================\t");
            Console.WriteLine("\t|           Lista de Clientes          |\t");
            Console.WriteLine("\t========================================\t");
            Console.WriteLine();

            foreach (Cliente clienteCadastrado in ClienteDAO.Listar())
            {
                Console.WriteLine($"{clienteCadastrado}");
            }
            Console.ReadKey();
        }
    }
}
