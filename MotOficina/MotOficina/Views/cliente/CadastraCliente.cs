using MotOficina.Dal;
using MotOficina.Models;
using MotOficina.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace MotOficina.Views.cliente
{
    class CadastraCliente
    {
        public static void ExecCadastro()
        {
            Cliente c = new Cliente();

            Console.Clear();
            Console.WriteLine("\t========================================\t");
            Console.WriteLine("\t|         Cadastro de Clientes         |\t");
            Console.WriteLine("\t========================================\t");
            Console.WriteLine();

            Console.WriteLine("Informe o Nome do Cliente:");
            c.Nome = Console.ReadLine();
            Console.WriteLine("Informe o CPF do Cliente:");
            c.Cpf = Console.ReadLine();
            Console.WriteLine("Informe a Moto do Cliente:");
            c.Moto = Console.ReadLine();

            //VALIDAÇÃO DO CPF
            if (Validacao.ValidarCPF(c.Cpf))
            {
                if (ClienteDAO.Cadastrar(c))
                {
                    Console.WriteLine("Cliente Cadastrado!");
                }
                else
                {
                    Console.WriteLine("Cliente já existe.");
                }
            }
            else
            {
                Console.WriteLine("CPF inválido.");
            }


        }
    }
}
