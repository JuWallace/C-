using System;
using System.Collections.Generic;
using System.Text;

namespace MotOficina.Models
{
    class Veiculo
    { 
        public Veiculo()
        {
            CriadoEm = DateTime.Now;
        }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Placa { get; set; }
        public string Quilometro { get; set; }
        public DateTime CriadoEm { get; set; }

        public override string ToString()
        {
            return ($"Marca: {Marca} | Modelo: {Modelo} | Ano: {Ano} | Placa: {Placa} | Odometro: {Quilometro} | Criado Em: {CriadoEm}");
        }
    }
}
