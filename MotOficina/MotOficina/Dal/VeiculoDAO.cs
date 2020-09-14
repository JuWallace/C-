using MotOficina.Models;
using System.Collections.Generic;


namespace MotOficina.Dal
{
    class VeiculoDAO
    {
        private VeiculoDAO() { }
        private static List<Veiculo> veiculos = new List<Veiculo>();

        //MÉTODO LISTAR
        public static List<Veiculo> Listar() => veiculos;

        //MÉTODO BUSCAR
        public static Veiculo BuscarVeiculoPLaca(string placa)
        {
            foreach (Veiculo veiculoCadastrado in veiculos)
            {
                if (veiculoCadastrado.Placa == placa)
                {
                    return veiculoCadastrado;
                }
            }
            return null;
        }

        //MÉTODO CADASTRAR
        public static bool Cadastrar(Veiculo v)
        {
            if (BuscarVeiculoPLaca(v.Placa) == null)
            {
                veiculos.Add(v);
                return true;
            }
            return false;
        }
    }
}
