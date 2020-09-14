using MotOficina.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MotOficina.Dal
{
    class ClienteDAO
    {
        private ClienteDAO() { }
        private static List<Cliente> clientes = new List<Cliente>();

        //MÉTODO LISTAR
        public static List<Cliente> Listar() => clientes;

        //MÉTODO BUSCAR
        public static Cliente BuscarClienteCPF(string cpf)
        {
            foreach (Cliente clienteCadastrado in clientes)
            {
                if(clienteCadastrado.Cpf == cpf)
                {
                    return clienteCadastrado;
                }
            }
            return null;
        }

        //MÉTODO CADASTRAR
        public static bool Cadastrar(Cliente c)
        {
            if(BuscarClienteCPF(c.Cpf) == null)
            {
                clientes.Add(c);
                return true;   
            }
            return false;
        }



    }
}
