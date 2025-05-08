using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeiculoClass
{
    public class Movimentacao
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public DateTime HoraEntrada { get; set; }
        public DateTime? HoraSaida { get; set; }  // Pode ser null enquanto o veículo estiver estacionado
        public decimal? ValorPago { get; set; }   // Também pode ser null até o pagamento
    }
}
