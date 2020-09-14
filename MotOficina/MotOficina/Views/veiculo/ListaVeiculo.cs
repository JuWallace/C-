using MotOficina.Dal;
using MotOficina.Models;
using System;


namespace MotOficina.Views.veiculo
{
    class ListaVeiculo
    {
        public static void ExecListar()
        {
            Console.WriteLine("\t========================================\t");
            Console.WriteLine("\t|           Lista de Veículos          |\t");
            Console.WriteLine("\t========================================\t");
            Console.WriteLine();

            foreach (Veiculo veiculoCadastrado in VeiculoDAO.Listar())
            {
                Console.WriteLine($"{veiculoCadastrado}");
            }
            Console.ReadKey();
        }
    }
}
