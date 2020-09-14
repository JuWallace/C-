using MotOficina.Dal;
using MotOficina.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MotOficina.Views.veiculo
{
    class CadastraVeiculo
    {
        public static void ExecCadastro()
        {
            Veiculo v = new Veiculo();

            Console.Clear();
            Console.WriteLine("\t========================================\t");
            Console.WriteLine("\t|         Cadastro de Veículos         |\t");
            Console.WriteLine("\t========================================\t");
            Console.WriteLine();

            Console.WriteLine("Informe a Marca:");
            v.Marca = Console.ReadLine();
            Console.WriteLine("Informe o Modelo:");
            v.Modelo = Console.ReadLine();
            Console.WriteLine("Informe o Ano:");
            v.Ano = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe a Placa:");
            v.Placa = Console.ReadLine();
            Console.WriteLine("Informe a Quilometragem:");
            v.Quilometro = Console.ReadLine();

            if (VeiculoDAO.Cadastrar(v))
            {
                Console.WriteLine("Veículo cadastrado!");
            }
            else
            {
                Console.WriteLine("Veiculo já existe!");
            }
        }
    }
}
