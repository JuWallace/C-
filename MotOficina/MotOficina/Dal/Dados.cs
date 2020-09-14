using MotOficina.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MotOficina.Dal
{
    class Dados
    {
        public static void Carregar()
        {
            Cliente c = new Cliente()
            {
                Nome = "Cliente1",
                Cpf  = "258.851.570-30",
                Moto = "XRE 190",
                CriadoEm = DateTime.Now

                //Nome = "Cliente2",
                //Cpf  = "166.500.300-66",
                //Nome = "Cliente3",
                //Cpf  = "01.492.470-01"
            };
            Veiculo v = new Veiculo()
            {
                Marca =  "Vendedor1",
                Modelo = "137.376.690-58",
                Ano    = 2018,
                Placa  = "aaa-1234",
                Quilometro = "20.001",
                CriadoEm = DateTime.Now
            };
            ClienteDAO.Cadastrar(c);
            VeiculoDAO.Cadastrar(v);
        }
    }
}
