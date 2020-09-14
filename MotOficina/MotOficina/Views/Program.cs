using MotOficina.Dal;
using System;

namespace MotOficina.Views
{
    class Program
    {
        static void Main(string[] args)
        {
            Dados.Carregar();
            MenuPrincipal.ExecMenuPrincipal();
        }
    }
}
