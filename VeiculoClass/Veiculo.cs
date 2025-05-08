using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeiculoClass
{
    public class Veiculo
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public DateTime HoraEntrada { get; set; }
        public DateTime? HoraSaida { get; internal set; }
        public decimal? ValorPago { get; internal set; }

        public Veiculo() { }
        public Veiculo(int id, string placa, string modelo, DateTime horaEntrada, DateTime? horaSaida, decimal? valorPago)
        {
            Id = id;
            Placa = placa;
            Modelo = modelo;
            HoraEntrada = horaEntrada;
            HoraSaida = horaSaida;
            ValorPago = valorPago;
        }
        public Veiculo(int id, string placa, string modelo, DateTime horaEntrada)
        {
            Id = id;
            Placa = placa;
            Modelo = modelo;
            HoraEntrada = horaEntrada;
        }

        public Veiculo(int id, string placa, string modelo)
        {
            Id = id;
            Placa = placa;
            Modelo = modelo;
        }      
    }     
}
